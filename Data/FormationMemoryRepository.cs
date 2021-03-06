﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Data
{
   public class FormationMemoryRepository
    {
        private List<Formation> _formations = new List<Formation>();
        public FormationMemoryRepository()
        {
            _formations.Add(new Formation { Id = 1, Nom = "Créer votre site pro", NomSeo = "phppro", Description = "une formation pour débutant" });
            _formations.Add(new Formation { Id = 1, Nom = "Créer votre site pro", NomSeo = "phppro", Description = "une formation pour débutant" });
            _formations.Add(new Formation { Id = 1, Nom = "Créer votre site pro", NomSeo = "phppro", Description = "une formation pour débutant" });
            _formations.Add(new Formation { Id = 1, Nom = "Créer votre site pro", NomSeo = "phppro", Description = "une formation pour débutant" });
        }
        public List<Formation> GetAllFormation()
        {
            return _formations;
        }

        public object GetFormationById(int iIdformation)
        {
            return _formations.FirstOrDefault(f => f.Id == iIdformation);
        }
    }
}
