using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HockeyManagement
{
    class Formation
    {
        string nom;
        FormationAttaquante attaque;
        FormationDefensive defense;
        Joueur gardien;

        public Formation(string nom, FormationAttaquante attaque, FormationDefensive defense, Joueur gardien)
        {
            this.nom = nom;
            this.attaque = attaque;
            this.defense = defense;
            this.gardien = gardien;
        }
    }
}
