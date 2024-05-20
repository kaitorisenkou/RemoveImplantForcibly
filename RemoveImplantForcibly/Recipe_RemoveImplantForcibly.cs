using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Verse;
using RimWorld;

namespace RemoveImplantForcibly {
    public class Recipe_RemoveImplantForcibly : Recipe_RemoveImplant {
        public override void ApplyOnPawn(Pawn pawn, BodyPartRecord part, Pawn billDoer, List<Thing> ingredients, Bill bill) {
            base.ApplyOnPawn(pawn, part, billDoer, ingredients, bill);
            pawn.Kill(
                new DamageInfo(
                    DamageDefOf.SurgicalCut,
                    99999f, 
                    999f, 
                    hitPart:part 
                    )
                );
        }
    }
}
