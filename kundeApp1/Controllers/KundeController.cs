using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using kundeApp1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace KundeApp1.Controllers
{
    [Route("[controller]/[action]")]
    public class KundeController : ControllerBase
    {
        private readonly KundeContext _db;

        public KundeController(KundeContext db)
        {
            _db = db;
        }

        public bool Lagre(Kunde innKunde)
        {
            try
            {
                _db.Kunder.Add(innKunde);
                _db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }


        public List<Kunde> HentAlle()
        {
            try
            {
                List<Kunde> alleKundene = _db.Kunder.ToList(); // hent hele tabellen
                return alleKundene;
            }
            catch
            {
                return null;
            }
        }

        public bool Slett(int id)
        {
            try
            {
                Kunde enKunde = _db.Kunder.Find(id);
                _db.Kunder.Remove(enKunde);
                _db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public Kunde HentEn(int id)
        {
            try
            {
                Kunde enKunde = _db.Kunder.Find(id);
                return enKunde;
            }
            catch
            {
                return null;
            }
        }

        public bool Endre(Kunde endreKunde)
        {
            try
            {
                Kunde enKunde = _db.Kunder.Find(endreKunde.Id);
                enKunde.Navn = endreKunde.Navn;
                enKunde.Adresse = endreKunde.Adresse;
                _db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}

