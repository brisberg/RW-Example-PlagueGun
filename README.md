#PlagueGun - Rimworld Example Mod

Tutorial source: https://ludeon.com/forums/index.php?topic=33219.0

Clone to repo into your Rimworld mods directory: Steam/steamapps/common/Rimworld/Mods/PlagueGun

Use Visual Studio 2017 Community Edition to build the Assembly. Open the Solution and hit Debug build.

Includes example of custom C# classes and associated XML defs.

###Local Modifications
Some Local modifications were required to bring the tutorial up to date with modern game versions.

- ThingDef_PlagueBullet needed to resolve a reference to the Plague definition after loading (though ResolveReferences())
- Projectile_PlagueBullet I commented out the message translation code because it has changed significantly, no alternative yet
- RangedWeapon_PlagueGun.xml 
    - Sound defs have been renamed: InteractRevolver -> Interact_Revolver, ShotRevolver -> Shot_Revolver
    - Property WeaponBulk seems to have been removed, removed from def.
    - Component items used in the Cost attribute has been renamed to Component_Industrial