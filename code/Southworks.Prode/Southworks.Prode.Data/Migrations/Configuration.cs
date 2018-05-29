using System;
using System.Data.Entity.Migrations;
using Southworks.Prode.Data.Models;

namespace Southworks.Prode.Data.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<Southworks.Prode.Data.ProdeDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Southworks.Prode.Data.ProdeDbContext context)
        {
            context.CountriesDbSet.AddOrUpdate(x => x.Code,
                new CountryEntity { Id = Guid.NewGuid(), Name = "Alemania", Code = "GER" },
                new CountryEntity { Id = Guid.NewGuid(), Name = "Arabia Saud�", Code = "KSA" },
                new CountryEntity { Id = Guid.NewGuid(), Name = "Argentina", Code = "ARG" },
                new CountryEntity { Id = Guid.NewGuid(), Name = "Australia", Code = "AUS" },
                new CountryEntity { Id = Guid.NewGuid(), Name = "B�lgica", Code = "BEL" },
                new CountryEntity { Id = Guid.NewGuid(), Name = "Brasil", Code = "BRA" },
                new CountryEntity { Id = Guid.NewGuid(), Name = "Colombia", Code = "COL" },
                new CountryEntity { Id = Guid.NewGuid(), Name = "Costa Rica", Code = "CRC" },
                new CountryEntity { Id = Guid.NewGuid(), Name = "Croacia", Code = "CRO" },
                new CountryEntity { Id = Guid.NewGuid(), Name = "Dinamarca", Code = "DEN" },
                new CountryEntity { Id = Guid.NewGuid(), Name = "Egipto", Code = "EGY" },
                new CountryEntity { Id = Guid.NewGuid(), Name = "Espa�a", Code = "ESP" },
                new CountryEntity { Id = Guid.NewGuid(), Name = "Francia", Code = "FRA" },
                new CountryEntity { Id = Guid.NewGuid(), Name = "Inglaterra", Code = "ENG" },
                new CountryEntity { Id = Guid.NewGuid(), Name = "Islandia", Code = "ISL" },
                new CountryEntity { Id = Guid.NewGuid(), Name = "Jap�n", Code = "JPN" },
                new CountryEntity { Id = Guid.NewGuid(), Name = "Marruecos", Code = "MAR" },
                new CountryEntity { Id = Guid.NewGuid(), Name = "M�xico", Code = "MEX" },
                new CountryEntity { Id = Guid.NewGuid(), Name = "Nigeria", Code = "NGA" },
                new CountryEntity { Id = Guid.NewGuid(), Name = "Panam�", Code = "PAN" },
                new CountryEntity { Id = Guid.NewGuid(), Name = "Per�", Code = "PER" },
                new CountryEntity { Id = Guid.NewGuid(), Name = "Polonia", Code = "POL" },
                new CountryEntity { Id = Guid.NewGuid(), Name = "Portugal", Code = "POR" },
                new CountryEntity { Id = Guid.NewGuid(), Name = "Rep�blica de Corea", Code = "KOR" },
                new CountryEntity { Id = Guid.NewGuid(), Name = "RI de Ir�n", Code = "IRN" },
                new CountryEntity { Id = Guid.NewGuid(), Name = "Rusia", Code = "RUS" },
                new CountryEntity { Id = Guid.NewGuid(), Name = "Senegal", Code = "SEN" },
                new CountryEntity { Id = Guid.NewGuid(), Name = "Serbia", Code = "SRB" },
                new CountryEntity { Id = Guid.NewGuid(), Name = "Suecia", Code = "SWE" },
                new CountryEntity { Id = Guid.NewGuid(), Name = "Suiza", Code = "SUI" },
                new CountryEntity { Id = Guid.NewGuid(), Name = "T�nez", Code = "TUN" },
                new CountryEntity { Id = Guid.NewGuid(), Name = "Uruguay", Code = "URU" }
                );

            context.UsersDbSet.AddOrUpdate(x => x.Email,
                new UserEntity { Id = Guid.NewGuid(), Name = "Nicol�s Bajk�", Email = "nicolas.bajko@soutworks.com", AccessLevel = UserAccessLevel.Admin }
                );
        }
    }
}
