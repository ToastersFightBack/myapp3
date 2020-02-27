using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using myapp.Models;

namespace myapp.DAL
{
    public class MemeInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<memecontext>
    {
        protected override void Seed(memecontext context)
        {
            var Funny = new List<Funny>
            {
                new Funny{Mouse="Vertical Mouse", Headphones="Logitech g933 Artimis Spectrum", VeryGood="Very good"},
                new Funny{Mouse="Xbox Controller", Headphones="Xbox Headset", VeryGood="Not good"}
            };
            Funny.ForEach(s => context.Funny.Add(s));
            context.SaveChanges();

            var Shinbreaker = new List<Shinbreaker>
            {
                new Shinbreaker{Joke="Big Chungus", FunnyLevel="Stomach Breaker", Rating=1},
                new Shinbreaker{Joke="Uganda Knuckles", FunnyLevel="Kinda Funny", Rating=50}
            };
            Shinbreaker.ForEach(s => context.Shinbreaker.Add(s));
            context.SaveChanges();
            var Notfunny = new List<Notfunny>
            {
                new Notfunny{Price=527, CableType="USB Type C", Phone="Razer gaming phone"},
                new Notfunny{Price=599, Phone="Iphone X", CableType="Daisy Type"}
            };
            Notfunny.ForEach(s => context.Notfunny.Add(s));
            context.SaveChanges();
        }

    }
}