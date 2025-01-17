﻿using System.ComponentModel.DataAnnotations;

namespace appmvc_projet2.Models.Services.TransportPersonnes
{
    public class TransportDePersonnes
    {
        public int Id { get; set; }
        public int? ServiceId { get; set; }
        public Service Service { get; set; }
        [Display(Name = "Nombre de places")]
        public int NombreDePlace { get; set; }
        [Display(Name = "Modèle du véhicule")]
        public string Modele { get; set; }
        [Display(Name = "Couleur du modèle")]
        public string CouleurModele { get; set; }
    }
}
