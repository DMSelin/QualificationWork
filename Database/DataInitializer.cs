using System;
using QualificationWork.Models;
using System.Collections.Generic;
using System.Linq;

namespace QualificationWork.Database
{
    public class DataInitializer : IDataInitializer
    {
        private readonly ProjectDbContext dbContext;
        public DataInitializer(ProjectDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void Init()
        {
            this.InitNomenclatures();
            this.InitBranches();
        }


        private void InitNomenclatures()
        {
            if (this.dbContext.Nomenclatures.Count() == 0)
            {
                var users = new List<Nomenclature>
                {
                    new Nomenclature { Id = Guid.NewGuid(), Code = "N-001", Name = "Общий анализ крови", Date = DateTime.Now, CreatedDate = DateTime.Now, UpdateDate = DateTime.Now, Price = "270 руб", IsActive = true},
                    new Nomenclature { Id = Guid.NewGuid(), Code = "N-002", Name = "Глюкоза в плазме", Date = DateTime.Now, CreatedDate = DateTime.Now, UpdateDate = DateTime.Now, Price = "190 руб", IsActive = true },
                    new Nomenclature { Id = Guid.NewGuid(), Code = "N-003", Name = "Скорость оседания эритроцитов", Date = DateTime.Now, CreatedDate = DateTime.Now, UpdateDate = DateTime.Now, Price = "190 руб", IsActive = true },
                    new Nomenclature { Id = Guid.NewGuid(), Code = "N-004", Name = "Холестерол общий", Date = DateTime.Now, CreatedDate = DateTime.Now, UpdateDate = DateTime.Now, Price = "235 руб", IsActive = true },
                    new Nomenclature { Id = Guid.NewGuid(), Code = "N-005", Name = "Тиреотропный гормон", Date = DateTime.Now, CreatedDate = DateTime.Now, UpdateDate = DateTime.Now, Price = "400 руб", IsActive = true },
                    new Nomenclature { Id = Guid.NewGuid(), Code = "N-006", Name = "Билирубин общий", Date = DateTime.Now, CreatedDate = DateTime.Now, UpdateDate = DateTime.Now, Price = "200 руб", IsActive = true },
                    new Nomenclature { Id = Guid.NewGuid(), Code = "N-007", Name = "Тироксин свободный", Date = DateTime.Now, CreatedDate = DateTime.Now, UpdateDate = DateTime.Now, Price = "485 руб", IsActive = true },
                    new Nomenclature { Id = Guid.NewGuid(), Code = "N-008", Name = "Анализ кала на яйца гельминтов", Date = DateTime.Now, CreatedDate = DateTime.Now, UpdateDate = DateTime.Now, Price = "340 руб", IsActive = true },
                    new Nomenclature { Id = Guid.NewGuid(), Code = "N-009", Name = "Взятие крови из периферической вены", Date = DateTime.Now, CreatedDate = DateTime.Now, UpdateDate = DateTime.Now, Price = "170 руб", IsActive = true },
                    new Nomenclature { Id = Guid.NewGuid(), Code = "N-010", Name = "Анализ кала на цисты и вегетативные формы простейших", Date = DateTime.Now, CreatedDate = DateTime.Now, UpdateDate = DateTime.Now, Price = "340 руб", IsActive = true },
                    new Nomenclature { Id = Guid.NewGuid(), Code = "N-011", Name = "Фосфатаза щелочная общая", Date = DateTime.Now, CreatedDate = DateTime.Now, UpdateDate = DateTime.Now, Price = "200 руб", IsActive = true },
                    new Nomenclature { Id = Guid.NewGuid(), Code = "N-012", Name = "Фолликулостимулирующий гормон", Date = DateTime.Now, CreatedDate = DateTime.Now, UpdateDate = DateTime.Now, Price = "485 руб", IsActive = true },
                    new Nomenclature { Id = Guid.NewGuid(), Code = "N-013", Name = "Тестостерон", Date = DateTime.Now, CreatedDate = DateTime.Now, UpdateDate = DateTime.Now, Price = "475 руб", IsActive = true },
                    new Nomenclature { Id = Guid.NewGuid(), Code = "N-014", Name = "Трийодтиронин свободный", Date = DateTime.Now, CreatedDate = DateTime.Now, UpdateDate = DateTime.Now, Price = "450 руб", IsActive = true },
                    new Nomenclature { Id = Guid.NewGuid(), Code = "N-015", Name = "Клинический анализ крови: общий анализ, лейкоцитарная формула, СОЭ", Date = DateTime.Now, CreatedDate = DateTime.Now, UpdateDate = DateTime.Now, Price = "655 руб", IsActive = true },
                    new Nomenclature { Id = Guid.NewGuid(), Code = "N-016", Name = "Общий анализ мочи с микроскопией осадка", Date = DateTime.Now, CreatedDate = DateTime.Now, UpdateDate = DateTime.Now, Price = "325 руб", IsActive = true },
                    new Nomenclature { Id = Guid.NewGuid(), Code = "N-017", Name = " Клинический анализ крови (c лейкоцитарной формулой)", Date = DateTime.Now, CreatedDate = DateTime.Now, UpdateDate = DateTime.Now, Price = "545 руб", IsActive = true },
                    new Nomenclature { Id = Guid.NewGuid(), Code = "N-018", Name = "Аланинаминотрансфераза (АЛТ)", Date = DateTime.Now, CreatedDate = DateTime.Now, UpdateDate = DateTime.Now, Price = "190 руб", IsActive = true },
                    new Nomenclature { Id = Guid.NewGuid(), Code = "N-019", Name = "Anti-HCV, антитела, ИФА", Date = DateTime.Now, CreatedDate = DateTime.Now, UpdateDate = DateTime.Now, Price = "540 руб", IsActive = true },
                    new Nomenclature { Id = Guid.NewGuid(), Code = "N-020", Name = "Креатинин в сыворотке (с определением СКФ)", Date = DateTime.Now, CreatedDate = DateTime.Now, UpdateDate = DateTime.Now, Price = "210 руб", IsActive = true },
                };

                this.dbContext.Nomenclatures.AddRange(users);
                this.dbContext.SaveChanges();
            }
        }

        private void InitBranches()
        {
            if (this.dbContext.Branches.Count() == 0)
            {
                var branches = new List<Branche>
                {
                    new Branche { Id = Guid.NewGuid(), Code = "B-001", Name = "1", Adress = "st", CreatedDate = DateTime.Now, UpdateDate = DateTime.Now, IsActive = true},
                    new Branche { Id = Guid.NewGuid(), Code = "B-002", Name = "2", Adress = "st", CreatedDate = DateTime.Now, UpdateDate = DateTime.Now, IsActive = true },
                    new Branche { Id = Guid.NewGuid(), Code = "B-003", Name = "3", Adress = "st", CreatedDate = DateTime.Now, UpdateDate = DateTime.Now, IsActive = true },
                    new Branche { Id = Guid.NewGuid(), Code = "B-004", Name = "4", Adress = "st", CreatedDate = DateTime.Now, UpdateDate = DateTime.Now, IsActive = true },
                    new Branche { Id = Guid.NewGuid(), Code = "B-005", Name = "5", Adress = "st", CreatedDate = DateTime.Now, UpdateDate = DateTime.Now, IsActive = true },
                    new Branche { Id = Guid.NewGuid(), Code = "B-006", Name = "6", Adress = "st", CreatedDate = DateTime.Now, UpdateDate = DateTime.Now, IsActive = true },
                    new Branche { Id = Guid.NewGuid(), Code = "B-007", Name = "7", Adress = "st", CreatedDate = DateTime.Now, UpdateDate = DateTime.Now, IsActive = true },
                    new Branche { Id = Guid.NewGuid(), Code = "B-008", Name = "8", Adress = "st", CreatedDate = DateTime.Now, UpdateDate = DateTime.Now, IsActive = true },
                    new Branche { Id = Guid.NewGuid(), Code = "B-009", Name = "9", Adress = "st", CreatedDate = DateTime.Now, UpdateDate = DateTime.Now, IsActive = true },
                    new Branche { Id = Guid.NewGuid(), Code = "B-010", Name = "10", Adress = "st", CreatedDate = DateTime.Now, UpdateDate = DateTime.Now, IsActive = true },
                };                                                                         

                this.dbContext.Branches.AddRange(branches);
                this.dbContext.SaveChanges();
            }
        }
    }
}
