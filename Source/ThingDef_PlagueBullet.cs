using RimWorld;
using Verse;

namespace Plague
{
  public class ThingDef_PlagueBullet : ThingDef
  {
    public float AddHediffChance = 0.05f; //The default chance of adding a hediff.
    public HediffDef HediffToAdd;

    public override void ResolveReferences()
    {
      base.ResolveReferences();
      LongEventHandler.ExecuteWhenFinished(delegate
      {
        this.HediffToAdd = HediffDefOf.Plague;
      });
    }
  }
}
