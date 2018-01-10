using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using TBP.klaseZaPrikaz;
using TBP.model;

namespace TBP.Database
{
    public class RadSBazom
    {

        public List<JedinicaMjereArtikla> dohvatiSveJediniceMjeraArtikla()
        {
            List<JedinicaMjereArtikla> lista = new List<JedinicaMjereArtikla>();

            NpgsqlConnection conn = new NpgsqlConnection("Server=127.0.0.1;User Id=postgres;" +
                                "Password=postgres;Database=tbp_baza;");
            conn.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("select * from jedinica_mjere_artikla " +
                "ORDER BY jedinica_mjere_artikla.naziv;", conn);
            
            NpgsqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                JedinicaMjereArtikla jedinica = new JedinicaMjereArtikla();
                jedinica.Id = (int)dr[0];
                jedinica.Naziv = dr[1].ToString();
                lista.Add(jedinica);
            }

            conn.Close();
            return lista;
        }

        public void spremiJedinicuMjere(JedinicaMjereArtikla nova)
        {
            NpgsqlConnection conn = new NpgsqlConnection("Server=127.0.0.1;User Id=postgres;" +
                               "Password=postgres;Database=tbp_baza;");
            conn.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("insert into jedinica_mjere_artikla (naziv) VALUES ('"+ nova.Naziv + "')", conn);
            cmd.ExecuteNonQuery();
        }

        public void izmijeniJedinicuMjere(JedinicaMjereArtikla stara)
        {
            NpgsqlConnection conn = new NpgsqlConnection("Server=127.0.0.1;User Id=postgres;" +
                               "Password=postgres;Database=tbp_baza;");
            conn.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("update jedinica_mjere_artikla set naziv= '" + stara.Naziv + "' where id="+stara.Id, conn);
            cmd.ExecuteNonQuery();
        }

        public void brisanjeJediniceMjere(JedinicaMjereArtikla stara)
        {
            NpgsqlConnection conn = new NpgsqlConnection("Server=127.0.0.1;User Id=postgres;" +
                               "Password=postgres;Database=tbp_baza;");
            conn.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("delete from jedinica_mjere_artikla where id= " + stara.Id, conn);
            cmd.ExecuteNonQuery();
        }




        public List<Drzava> dohvatiSveDrzave()
        {
            List<Drzava> lista = new List<Drzava>();

            NpgsqlConnection conn = new NpgsqlConnection("Server=127.0.0.1;User Id=postgres;" +
                                "Password=postgres;Database=tbp_baza;");
            conn.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("select * from drzava ORDER BY drzava.naziv;", conn);

            NpgsqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Drzava drzava = new Drzava();
                drzava.Id = (int)dr[0];
                drzava.Naziv = dr[1].ToString();
                lista.Add(drzava);
            }
            conn.Close();
            return lista;
        }
        public void spremiDrzavu(Drzava nova)
        {
            NpgsqlConnection conn = new NpgsqlConnection("Server=127.0.0.1;User Id=postgres;" +
                               "Password=postgres;Database=tbp_baza;");
            conn.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("insert into drzava (naziv) VALUES ('" + nova.Naziv + "')", conn);
            cmd.ExecuteNonQuery();
        }
        public void izmijeniDrzavu(Drzava stara)
        {
            NpgsqlConnection conn = new NpgsqlConnection("Server=127.0.0.1;User Id=postgres;" +
                               "Password=postgres;Database=tbp_baza;");
            conn.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("update drzava set naziv= '" + stara.Naziv + "' where id=" + stara.Id, conn);
            cmd.ExecuteNonQuery();
        }
        public void brisanjeDrzave(Drzava stara)
        {
            NpgsqlConnection conn = new NpgsqlConnection("Server=127.0.0.1;User Id=postgres;" +
                               "Password=postgres;Database=tbp_baza;");
            conn.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("delete from drzava where id= " + stara.Id, conn);
            cmd.ExecuteNonQuery();
        }


        

        public List<Grad> dohvatiGradove()
        {
            List<Grad> listaGradova = new List<Grad>();
            NpgsqlConnection conn = new NpgsqlConnection("Server=127.0.0.1;User Id=postgres;" +
                               "Password=postgres;Database=tbp_baza;");
            conn.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("SELECT grad.id, grad.naziv, drzava.id, drzava.naziv "+
                                        "FROM grad JOIN drzava ON grad.id_drzave = drzava.id ORDER BY grad.naziv;", conn);
            NpgsqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Grad grad = new Grad();
                grad.Id = (int)dr[0];
                grad.Naziv = dr[1].ToString();
                grad.Drzava = new Drzava();
                grad.Drzava.Id= (int)dr[2];
                grad.Drzava.Naziv= dr[3].ToString();
                listaGradova.Add(grad);
            }
            conn.Close();
            return listaGradova;
        }

        public void spremiGrad(Grad novi)
        {
            NpgsqlConnection conn = new NpgsqlConnection("Server=127.0.0.1;User Id=postgres;" +
                               "Password=postgres;Database=tbp_baza;");
            conn.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("insert into grad (naziv, id_drzave) VALUES ('" + novi.Naziv + "', "+novi.Drzava.Id+")", conn);
            cmd.ExecuteNonQuery();
        }
        public void azurirajGrad(Grad stari)
        {
            NpgsqlConnection conn = new NpgsqlConnection("Server=127.0.0.1;User Id=postgres;" +
                               "Password=postgres;Database=tbp_baza;");
            conn.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("update grad set naziv='" + stari.Naziv + "', id_drzave = " + stari.Drzava.Id+" where id="+stari.Id, conn);
            cmd.ExecuteNonQuery();
        }
        public void obrisiGrad(Grad stari)
        {
            NpgsqlConnection conn = new NpgsqlConnection("Server=127.0.0.1;User Id=postgres;" +
                               "Password=postgres;Database=tbp_baza;");
            conn.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("delete from grad where id=" + stari.Id, conn);
            cmd.ExecuteNonQuery();
        }





        //Zaposlenici


        public List<Zaposlenik> dohvatiSveZaposlenike()
        {
            List<Zaposlenik> listaZaposlenika = new List<Zaposlenik>();
            NpgsqlConnection conn = new NpgsqlConnection("Server=127.0.0.1;User Id=postgres;" +
                               "Password=postgres;Database=tbp_baza;");
            conn.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("SELECT zaposlenik.id, zaposlenik.OIB, zaposlenik.ime, " +
                "zaposlenik.prezime, zaposlenik.email, zaposlenik.kontakt, zaposlenik.datum_zaposlenja, " +
                "zaposlenik.adresa, zaposlenik.id_grada, grad.naziv from zaposlenik join grad " +
                "on zaposlenik.id_grada = grad.id ORDER BY zaposlenik.prezime; ", conn);
            NpgsqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Zaposlenik zaposlenik = new Zaposlenik();
                zaposlenik.Id = (int)dr[0];
                zaposlenik.OIB = dr[1].ToString();
                zaposlenik.Ime = dr[2].ToString();
                zaposlenik.Prezime = dr[3].ToString();
                zaposlenik.Email = dr[4].ToString();
                zaposlenik.Kontakt = dr[5].ToString();
                zaposlenik.DatumZaposlenja = (DateTime)dr[6];
                zaposlenik.Adresa = dr[7].ToString();
                zaposlenik.Grad = new Grad();
                zaposlenik.Grad.Id= (int)dr[8];
                zaposlenik.Grad.Naziv= dr[9].ToString();
                listaZaposlenika.Add(zaposlenik);
            }
            conn.Close();
            return listaZaposlenika;
        }

        public void spremiZaposlenika(Zaposlenik novi)
        {
            NpgsqlConnection conn = new NpgsqlConnection("Server=127.0.0.1;User Id=postgres;" +
                               "Password=postgres;Database=tbp_baza;");
            conn.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("insert into zaposlenik (oib, ime, prezime, email, " +
                "kontakt, adresa, datum_zaposlenja, id_grada) values('"+novi.OIB+"', '"+novi.Ime+"', " +
                "'"+novi.Prezime+"', '"+novi.Email+"', '"+novi.Kontakt+"', '"+novi.Adresa+"', " +
                "'"+novi.DatumZaposlenja+"', "+novi.Grad.Id+");", conn);
            cmd.ExecuteNonQuery();
        }
        public void azurirajZaposlenika(Zaposlenik stari)
        {
            NpgsqlConnection conn = new NpgsqlConnection("Server=127.0.0.1;User Id=postgres;" +
                               "Password=postgres;Database=tbp_baza;");
            conn.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("update zaposlenik set oib='"+stari.OIB+"', ime='"+stari.Ime+"', " +
                "prezime='"+stari.Prezime+"', email='"+stari.Email+"', kontakt='"+stari.Kontakt+"', adresa='"+stari.Adresa+"', " +
                "datum_zaposlenja='"+stari.DatumZaposlenja+"', id_grada="+stari.Grad.Id+" where zaposlenik.id="+stari.Id, conn);
            cmd.ExecuteNonQuery();
        }
        public void obrisiZaposlenika(Zaposlenik stari)
        {
            NpgsqlConnection conn = new NpgsqlConnection("Server=127.0.0.1;User Id=postgres;" +
                               "Password=postgres;Database=tbp_baza;");
            conn.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("delete from zaposlenik where id=" + stari.Id, conn);
            cmd.ExecuteNonQuery();
        }






        //Poslovni partneri
        
        public List<PoslovniPartner> dohvatiSvePoslovnePartnere()
        {
            List<PoslovniPartner> listaPoslovnihPartnera = new List<PoslovniPartner>();
            NpgsqlConnection conn = new NpgsqlConnection("Server=127.0.0.1;User Id=postgres;" +
                               "Password=postgres;Database=tbp_baza;");
            conn.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("SELECT poslovni_partner.id, poslovni_partner.OIB, " +
                "poslovni_partner.naziv, poslovni_partner.email, poslovni_partner.kontakt, " +
                "poslovni_partner.datum_pocetka_partnerstva, poslovni_partner.adresa, poslovni_partner.id_grada, " +
                "grad.naziv from poslovni_partner join grad on poslovni_partner.id_grada = grad.id " +
                "ORDER BY poslovni_partner.naziv; ", conn);
            NpgsqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            { 
                PoslovniPartner partner = new PoslovniPartner();
                partner.Id = (int)dr[0];
                partner.OIB = dr[1].ToString();
                partner.Naziv = dr[2].ToString();
                partner.Email = dr[3].ToString();
                partner.Kontakt = dr[4].ToString();
                partner.DatumPocetkaPartnerstva = (DateTime)dr[5];
                partner.Adresa = dr[6].ToString();
                partner.Grad = new Grad();
                partner.Grad.Id = (int)dr[7];
                partner.Grad.Naziv = dr[8].ToString();
                listaPoslovnihPartnera.Add(partner);
            }
            conn.Close();
            return listaPoslovnihPartnera;
        }

        public void obrisiPoslovnogPartnera(PoslovniPartner stari)
        {
            NpgsqlConnection conn = new NpgsqlConnection("Server=127.0.0.1;User Id=postgres;" +
                               "Password=postgres;Database=tbp_baza;");
            conn.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("delete from poslovni_partner where id=" + stari.Id, conn);
            cmd.ExecuteNonQuery();
        }
        public void spremiPoslovnogPartnera(PoslovniPartner novi)
        {
            NpgsqlConnection conn = new NpgsqlConnection("Server=127.0.0.1;User Id=postgres;" +
                               "Password=postgres;Database=tbp_baza;");
            conn.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("insert into poslovni_partner (oib, naziv, email, " +
                "kontakt, adresa, datum_pocetka_partnerstva, id_grada) values('" + novi.OIB + "', '" + novi.Naziv + "', " +
                "'" + novi.Email + "', '" + novi.Kontakt + "', '" + novi.Adresa + "', " +
                "'" + novi.DatumPocetkaPartnerstva + "', " + novi.Grad.Id + ");", conn);
            cmd.ExecuteNonQuery();
        }
        public void azurirajPoslovnogPartnera(PoslovniPartner stari)
        {
            NpgsqlConnection conn = new NpgsqlConnection("Server=127.0.0.1;User Id=postgres;" +
                               "Password=postgres;Database=tbp_baza;");
            conn.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("update poslovni_partner set oib='" + stari.OIB + "', naziv='" + stari.Naziv + "', " +
                "email='" + stari.Email + "', kontakt='" + stari.Kontakt + "', adresa='" + stari.Adresa + "', " +
                "datum_pocetka_partnerstva='" + stari.DatumPocetkaPartnerstva + "', id_grada=" + stari.Grad.Id + " where poslovni_partner.id=" + stari.Id, conn);
            cmd.ExecuteNonQuery();
        }







        //Artikli
        public List<Artikl> dohvatiSveArtikle()
        {
            List<Artikl> listaArtikala = new List<Artikl>();
            NpgsqlConnection conn = new NpgsqlConnection("Server=127.0.0.1;User Id=postgres;" +
                               "Password=postgres;Database=tbp_baza;");
            conn.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("SELECT artikl.id, artikl.naziv,artikl.jedinicna_cijena, " +
                "artikl.kolicina_na_skladistu, artikl.minimalna_kolicina_na_skladistu,jedinica_mjere_artikla.id, " +
                "jedinica_mjere_artikla.naziv from artikl join jedinica_mjere_artikla on " +
                "artikl.id_jedinicne_mjere_artikla = jedinica_mjere_artikla.id ORDER BY artikl.naziv; ", conn);
            NpgsqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Artikl artikl = new Artikl();
                artikl.Id = (int)dr[0];
                artikl.Naziv = dr[1].ToString();
                artikl.JedinicnaCijena = float.Parse(dr[2].ToString());
                artikl.KolicinaNaSkladistu = (int)dr[3];
                artikl.MinimalnaKolicinaNaSkladistu = (int)dr[4];
                artikl.JedinicaMjere = new JedinicaMjereArtikla();
                artikl.JedinicaMjere.Id = (int)dr[5];
                artikl.JedinicaMjere.Naziv = dr[6].ToString();
                listaArtikala.Add(artikl);
            }
            conn.Close();
            return listaArtikala;
        }


        public void spremiArtikl(Artikl novi)
        {
            NpgsqlConnection conn = new NpgsqlConnection("Server=127.0.0.1;User Id=postgres;" +
                               "Password=postgres;Database=tbp_baza;");
            conn.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("insert into artikl (naziv, jedinicna_cijena, kolicina_na_skladistu, " +
                "minimalna_kolicina_na_skladistu, id_jedinicne_mjere_artikla) VALUES('" + novi.Naziv + "', " 
                + novi.JedinicnaCijena + ", " + novi.KolicinaNaSkladistu + ", " + novi.MinimalnaKolicinaNaSkladistu 
                + ", " + novi.JedinicaMjere.Id + ");", conn);
            cmd.ExecuteNonQuery();
        }
        public void azurirajArtikl(Artikl stari)
        {
            NpgsqlConnection conn = new NpgsqlConnection("Server=127.0.0.1;User Id=postgres;" +
                               "Password=postgres;Database=tbp_baza;");
            conn.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("update artikl set naziv='" + stari.Naziv + "', " +
                "jedinicna_cijena=" + stari.JedinicnaCijena + ", kolicina_na_skladistu=" + stari.KolicinaNaSkladistu +
                ", minimalna_kolicina_na_skladistu=" + stari.MinimalnaKolicinaNaSkladistu +
                ", id_jedinicne_mjere_artikla=" + stari.JedinicaMjere.Id + ",  where artikl.id=" + stari.Id, conn);
            cmd.ExecuteNonQuery();
        }

        public void obrisiArtikl(Artikl stari)
        {
            NpgsqlConnection conn = new NpgsqlConnection("Server=127.0.0.1;User Id=postgres;" +
                               "Password=postgres;Database=tbp_baza;");
            conn.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("delete from artikl where id=" + stari.Id, conn);
            cmd.ExecuteNonQuery();
        }





        //Dokumenti ulaza
        public DokumentUlaza dohvatiOdabraniDokumentZaPrikaz(int id)
        {
            NpgsqlConnection conn = new NpgsqlConnection("Server=127.0.0.1;User Id=postgres;" +
                               "Password=postgres;Database=tbp_baza;");
            conn.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("select dokument_ulaza.id, dokument_ulaza.naziv, " +
                "dokument_ulaza.datum, zaposlenik.id, zaposlenik.ime, zaposlenik.prezime, poslovni_partner.id, " +
                "poslovni_partner.naziv from dokument_ulaza, zaposlenik, poslovni_partner where " +
                "zaposlenik.id = dokument_ulaza.id_zaposlenika and " +
                "poslovni_partner.id = dokument_ulaza.id_poslovnog_partnera " +
                "and dokument_ulaza.id = " + id + "; ", conn);
            NpgsqlDataReader dr = cmd.ExecuteReader();
            DokumentUlaza dohvaceni = new DokumentUlaza();
            while (dr.Read())
            {
                dohvaceni.Id = (int)dr[0];
                dohvaceni.Naziv = dr[1].ToString();
                dohvaceni.Datum = (DateTime)dr[2];
                dohvaceni.Zaposlenik = new Zaposlenik();
                dohvaceni.Zaposlenik.Id = (int)dr[3];
                dohvaceni.Zaposlenik.Ime = dr[4].ToString();
                dohvaceni.Zaposlenik.Prezime = dr[5].ToString();
                dohvaceni.PoslovniPartner = new PoslovniPartner();
                dohvaceni.PoslovniPartner.Id = (int)dr[6];
                dohvaceni.PoslovniPartner.Naziv = dr[7].ToString();
            }
            conn.Close();
            return dohvaceni;
        }

        public List<DokumentUlaza> dohvatiSveDokumenteUlaza()
        {
            List<DokumentUlaza> listaDokumenataUlaza = new List<DokumentUlaza>();
            NpgsqlConnection conn = new NpgsqlConnection("Server=127.0.0.1;User Id=postgres;" +
                               "Password=postgres;Database=tbp_baza;");
            conn.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("select dokument_ulaza.id, dokument_ulaza.naziv, " +
                "dokument_ulaza.datum, zaposlenik.id, zaposlenik.ime, zaposlenik.prezime, poslovni_partner.id, " +
                "poslovni_partner.naziv from dokument_ulaza, zaposlenik, poslovni_partner where " +
                "zaposlenik.id = dokument_ulaza.id_zaposlenika and " +
                "poslovni_partner.id = dokument_ulaza.id_poslovnog_partnera;", conn);
            NpgsqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                DokumentUlaza dohvaceni = new DokumentUlaza();
                dohvaceni.Id = (int)dr[0];
                dohvaceni.Naziv = dr[1].ToString();
                dohvaceni.Datum = (DateTime)dr[2];
                dohvaceni.Zaposlenik = new Zaposlenik();
                dohvaceni.Zaposlenik.Id = (int)dr[3];
                dohvaceni.Zaposlenik.Ime = dr[4].ToString();
                dohvaceni.Zaposlenik.Prezime = dr[5].ToString();
                dohvaceni.PoslovniPartner = new PoslovniPartner();
                dohvaceni.PoslovniPartner.Id = (int)dr[6];
                dohvaceni.PoslovniPartner.Naziv = dr[7].ToString();
                listaDokumenataUlaza.Add(dohvaceni);
            }
            conn.Close();
            return listaDokumenataUlaza;
        }

        public List<Artikl> dohvatiPotrebneArtikle()
        {
            List<Artikl> listaPotrebnihArtikala = new List<Artikl>();
            NpgsqlConnection conn = new NpgsqlConnection("Server=127.0.0.1;User Id=postgres;" +
                               "Password=postgres;Database=tbp_baza;");
            conn.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("select artikl.id, artikl.naziv, artikl.kolicina_na_skladistu," +
                "artikl.minimalna_kolicina_na_skladistu from artikl where artikl.minimalna_kolicina_na_skladistu " +
                "> artikl.kolicina_na_skladistu ORDER BY artikl.naziv;", conn);
            NpgsqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Artikl dohvaceni = new Artikl();
                dohvaceni.Id = (int)dr[0];
                dohvaceni.Naziv = dr[1].ToString();
                dohvaceni.KolicinaNaSkladistu = (int)dr[2];
                dohvaceni.MinimalnaKolicinaNaSkladistu = (int)dr[3];
                listaPotrebnihArtikala.Add(dohvaceni);
            }
            conn.Close();
            return listaPotrebnihArtikala;
        }

        public void spremiUlazniDokument(DokumentUlaza dokumentUlaza)
        {
            NpgsqlConnection conn = new NpgsqlConnection("Server=127.0.0.1;User Id=postgres;" +
                               "Password=postgres;Database=tbp_baza;");
            conn.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("insert into dokument_ulaza (naziv, datum, " +
                "id_poslovnog_partnera, id_zaposlenika) values ('"+dokumentUlaza.Naziv+"', '"
                +dokumentUlaza.Datum+"', "+dokumentUlaza.PoslovniPartner.Id+", "+dokumentUlaza.Zaposlenik.Id+");", conn);
            cmd.ExecuteNonQuery();


            NpgsqlCommand cmdSelect = new NpgsqlCommand("select dokument_ulaza.id from dokument_ulaza where dokument_ulaza.datum='"+dokumentUlaza.Datum+"'; ", conn);
            NpgsqlDataReader dr = cmdSelect.ExecuteReader();

            int idDokumenta = 0;
            while (dr.Read())
            {
                idDokumenta = (int)dr[0];
            }
            dr.Close(); 

            for (int i = 0; i < dokumentUlaza.Stavke.Count; i++)
            {
                NpgsqlCommand cmdStavke = new NpgsqlCommand("insert into stavke_dokumenta_ulaza (id_artikla, id_dokumenta_ulaza, " +
                    "kolicina) values (" + dokumentUlaza.Stavke[i].Artikl.Id + ", " + idDokumenta + ", " + dokumentUlaza.Stavke[i].Kolicina + ");", conn);
                    cmdStavke.ExecuteNonQuery();
            }
            conn.Close();
        }


        public List<PrikazStavkiDokumentaUlaza> dohvatiStavkeDokumentaUlazZaPrikazDetalja(int idDokumenta)
        {
            List<PrikazStavkiDokumentaUlaza> listaPrikazaStavki = new List<PrikazStavkiDokumentaUlaza>();
            NpgsqlConnection conn = new NpgsqlConnection("Server=127.0.0.1;User Id=postgres;" +
                               "Password=postgres;Database=tbp_baza;");
            conn.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("select artikl.naziv, artikl.jedinicna_cijena, " +
                "stavke_dokumenta_ulaza.kolicina from artikl, stavke_dokumenta_ulaza where " +
                "stavke_dokumenta_ulaza.id_artikla=artikl.id and stavke_dokumenta_ulaza.id_dokumenta_ulaza="
                +idDokumenta+";", conn);

            NpgsqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                PrikazStavkiDokumentaUlaza dohvaceni = new PrikazStavkiDokumentaUlaza();
                dohvaceni.Naziv = dr[0].ToString();
                dohvaceni.JedinicnaCijena = float.Parse(dr[1].ToString());
                dohvaceni.Kolicina = int.Parse(dr[2].ToString());
                listaPrikazaStavki.Add(dohvaceni);
            }
            conn.Close();

            return listaPrikazaStavki;
        }





        //Dokument izlaza

        public DokumentIzlaza dohvatiOdabraniDokumentIzlazaZaPrikaz(int id)
        {
            NpgsqlConnection conn = new NpgsqlConnection("Server=127.0.0.1;User Id=postgres;" +
                               "Password=postgres;Database=tbp_baza;");
            conn.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("select dokument_izlaza.id, dokument_izlaza.naziv, " +
                "dokument_izlaza.datum, zaposlenik.id, zaposlenik.ime, zaposlenik.prezime, poslovni_partner.id, " +
                "poslovni_partner.naziv from dokument_izlaza, zaposlenik, poslovni_partner where " +
                "zaposlenik.id = dokument_izlaza.id_zaposlenika and " +
                "poslovni_partner.id = dokument_izlaza.id_poslovnog_partnera " +
                "and dokument_izlaza.id = " + id + "; ", conn);
            NpgsqlDataReader dr = cmd.ExecuteReader();
            DokumentIzlaza dohvaceni = new DokumentIzlaza();
            while (dr.Read())
            {
                dohvaceni.Id = (int)dr[0];
                dohvaceni.Naziv = dr[1].ToString();
                dohvaceni.Datum = (DateTime)dr[2];
                dohvaceni.Zaposlenik = new Zaposlenik();
                dohvaceni.Zaposlenik.Id = (int)dr[3];
                dohvaceni.Zaposlenik.Ime = dr[4].ToString();
                dohvaceni.Zaposlenik.Prezime = dr[5].ToString();
                dohvaceni.PoslovniPartner = new PoslovniPartner();
                dohvaceni.PoslovniPartner.Id = (int)dr[6];
                dohvaceni.PoslovniPartner.Naziv = dr[7].ToString();
            }
            conn.Close();
            return dohvaceni;
        }

        public List<DokumentIzlaza> dohvatiSveDokumenteIzlaza()
        {
            List<DokumentIzlaza> listaDokumenataIzlaza = new List<DokumentIzlaza>();
            NpgsqlConnection conn = new NpgsqlConnection("Server=127.0.0.1;User Id=postgres;" +
                               "Password=postgres;Database=tbp_baza;");
            conn.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("select dokument_izlaza.id, dokument_izlaza.naziv, " +
                "dokument_izlaza.datum, zaposlenik.id, zaposlenik.ime, zaposlenik.prezime, poslovni_partner.id, " +
                "poslovni_partner.naziv from dokument_izlaza, zaposlenik, poslovni_partner where " +
                "zaposlenik.id = dokument_izlaza.id_zaposlenika and " +
                "poslovni_partner.id = dokument_izlaza.id_poslovnog_partnera;", conn);
            NpgsqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                DokumentIzlaza dohvaceni = new DokumentIzlaza();
                dohvaceni.Id = (int)dr[0];
                dohvaceni.Naziv = dr[1].ToString();
                dohvaceni.Datum = (DateTime)dr[2];
                dohvaceni.Zaposlenik = new Zaposlenik();
                dohvaceni.Zaposlenik.Id = (int)dr[3];
                dohvaceni.Zaposlenik.Ime = dr[4].ToString();
                dohvaceni.Zaposlenik.Prezime = dr[5].ToString();
                dohvaceni.PoslovniPartner = new PoslovniPartner();
                dohvaceni.PoslovniPartner.Id = (int)dr[6];
                dohvaceni.PoslovniPartner.Naziv = dr[7].ToString();
                listaDokumenataIzlaza.Add(dohvaceni);
            }
            conn.Close();
            return listaDokumenataIzlaza;
        }

        public List<Artikl> dohvatiPotrebneArtikleZaIzlaz()
        {
            List<Artikl> listaPotrebnihArtikala = new List<Artikl>();
            NpgsqlConnection conn = new NpgsqlConnection("Server=127.0.0.1;User Id=postgres;" +
                               "Password=postgres;Database=tbp_baza;");
            conn.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("select artikl.id, artikl.naziv, artikl.kolicina_na_skladistu," +
                "artikl.minimalna_kolicina_na_skladistu from artikl where artikl.minimalna_kolicina_na_skladistu " +
                "< artikl.kolicina_na_skladistu ORDER BY artikl.naziv;", conn);
            NpgsqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Artikl dohvaceni = new Artikl();
                dohvaceni.Id = (int)dr[0];
                dohvaceni.Naziv = dr[1].ToString();
                dohvaceni.KolicinaNaSkladistu = (int)dr[2];
                dohvaceni.MinimalnaKolicinaNaSkladistu = (int)dr[3];
                listaPotrebnihArtikala.Add(dohvaceni);
            }
            conn.Close();
            return listaPotrebnihArtikala;
        }

        public void spremiIzlazniDokument(DokumentIzlaza dokumentIzlaza)
        {
            NpgsqlConnection conn = new NpgsqlConnection("Server=127.0.0.1;User Id=postgres;" +
                               "Password=postgres;Database=tbp_baza;");
            conn.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("insert into dokument_izlaza (naziv, datum, " +
                "id_poslovnog_partnera, id_zaposlenika) values ('" + dokumentIzlaza.Naziv + "', '"
                + dokumentIzlaza.Datum + "', " + dokumentIzlaza.PoslovniPartner.Id + ", " + dokumentIzlaza.Zaposlenik.Id + ");", conn);
            cmd.ExecuteNonQuery();


            NpgsqlCommand cmdSelect = new NpgsqlCommand("select dokument_izlaza.id from dokument_izlaza where dokument_izlaza.datum='" + dokumentIzlaza.Datum + "'; ", conn);
            NpgsqlDataReader dr = cmdSelect.ExecuteReader();

            int idDokumenta = 0;
            while (dr.Read())
            {
                idDokumenta = (int)dr[0];
            }
            dr.Close();

            for (int i = 0; i < dokumentIzlaza.Stavke.Count; i++)
            {
                NpgsqlCommand cmdStavke = new NpgsqlCommand("insert into stavke_dokumenta_izlaza (id_artikla, id_dokumenta_izlaza, " +
                    "kolicina) values (" + dokumentIzlaza.Stavke[i].Artikl.Id + ", " + idDokumenta + ", " + dokumentIzlaza.Stavke[i].Kolicina + ");", conn);
                cmdStavke.ExecuteNonQuery();
            }
            conn.Close();
        }

        public List<PrikazStavkiDokumentaIzlaza> dohvatiStavkeDokumentaIzlazZaPrikazDetalja(int idDokumenta)
        {
            List<PrikazStavkiDokumentaIzlaza> listaPrikazaStavki = new List<PrikazStavkiDokumentaIzlaza>();
            NpgsqlConnection conn = new NpgsqlConnection("Server=127.0.0.1;User Id=postgres;" +
                               "Password=postgres;Database=tbp_baza;");
            conn.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("select artikl.naziv, artikl.jedinicna_cijena, " +
                "stavke_dokumenta_izlaza.kolicina from artikl, stavke_dokumenta_izlaza where " +
                "stavke_dokumenta_izlaza.id_artikla=artikl.id and stavke_dokumenta_izlaza.id_dokumenta_izlaza="
                + idDokumenta + ";", conn);

            NpgsqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                PrikazStavkiDokumentaIzlaza dohvaceni = new PrikazStavkiDokumentaIzlaza();
                dohvaceni.Naziv = dr[0].ToString();
                dohvaceni.JedinicnaCijena = float.Parse(dr[1].ToString());
                dohvaceni.Kolicina = int.Parse(dr[2].ToString());
                listaPrikazaStavki.Add(dohvaceni);
            }
            conn.Close();

            return listaPrikazaStavki;
        }

        
    }
}
