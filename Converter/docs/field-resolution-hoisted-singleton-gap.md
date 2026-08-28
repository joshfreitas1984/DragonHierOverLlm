# Field-resolution passes (3d/3e) miss instance-field offsets when the singleton pointer is hoisted across statements

For a singleton chain written as:
```csharp
var pGameDataController = *(int64*)(GameDataController_StaticsPtr + 184);
// ...several lines later...
lVar3 = *(int64 *)(pGameDataController + 0x1d8);
```
passes 3d/3e currently treat the hoisted `pClassName`-named local strictly as a "statics block
pointer" (for resolving further `ClassName.staticField` reads), not as the resolved *instance*
pointer it actually is in this shape (offset `0xb8`/184 here holds the singleton instance pointer
directly, one dereference deep — not a statics-block base to add further static offsets to). The
existing chain-form resolution in 3e/3f (`*(type*)(*pVar + OFFSET) →
ClassName.instance.instanceField`) only fires when the dereference and offset-add appear together
in one inline expression; it doesn't fire once the singleton pointer has already been captured
into a separately-named local several statements earlier.

**Net effect**: instance field offsets like `+0x1d8` on a hoisted singleton local are left as raw
pointer arithmetic instead of being resolved to `GameDataController.someFieldName`.

**Found while investigating**: the `StartMenuController.ResetFaceSetting`/`ResetPlayerTag` crash
(see `DragonHeirPlugin/docs/resetfacesetting-crash-investigation.md`) — worked around there via a
runtime reflection-based diagnostic patch instead of fixing this pass, since getting real field
names from a live process is more reliable than perfecting this disambiguation.

**If tackled properly**, the fix likely belongs in pass 3e/3f: track hoisted `pClassName` locals
that were assigned from a *known instance-typed* static field offset (e.g. an
`_instance`/`Instance` static field, commonly at `0xb8` for singletons) and route subsequent
`pClassName + OFFSET` accesses through `type.FieldOffsets` (instance offsets) rather than
`type.StaticFieldOffsets`.
