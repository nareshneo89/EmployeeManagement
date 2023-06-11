using EmployeeManagement.Models.Administration;
using EmployeeManagement.Models.Administration.DynamicMenu;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Models
{
    public class AppDbContext: IdentityDbContext<ApplicationUser, ApplicationRole, string>
    {
        public AppDbContext(DbContextOptions<AppDbContext>options): base(options)
        {

        }
        public DbSet<Employee>Employees { get; set; }
        //public DbSet<MenuItem> MenuItems { get; set; }
        //public DbSet<MenuPermission> MenuPermissions { get; set; }
        //public DbSet<Permission> Permissions { get; set; }
        //public DbSet<ApplicationRoleMenu> RoleMenus { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Seed();

            //remove reference key
            //foreach(var foreignKey in modelBuilder.Model.GetEntityTypes().SelectMany(e=>e.GetForeignKeys()))
            //{
            //    foreignKey.DeleteBehavior = DeleteBehavior.Restrict;
            //}
            modelBuilder.Entity<MenuItem>(item =>
            {
                item.ToTable("AspNetMenu");
                item.HasMany(y => y.Children)
                    .WithOne(r => r.ParentItem)
                    .HasForeignKey(u => u.ParentId);

                item.HasMany(t => t.RoleMenus)
                    .WithOne(u => u.MenuItem)
                    .HasForeignKey(r => r.MenuId)
                    .OnDelete(DeleteBehavior.NoAction);
            });

            modelBuilder.Entity<ApplicationRoleMenu>(roleMenu =>
            {
                roleMenu.ToTable("AspNetRoleMenu");

                roleMenu.HasOne(o => o.Role)
                    .WithMany(u => u.RoleMenus)
                    .HasForeignKey(e => e.RoleId)
                    .OnDelete(DeleteBehavior.NoAction);

                roleMenu.HasOne(o => o.MenuItem)
                    .WithMany(u => u.RoleMenus)
                    .HasForeignKey(e => e.MenuId)
                    .OnDelete(DeleteBehavior.NoAction);
            });

            modelBuilder.Entity<MenuPermission>(mp =>
            {
                mp.ToTable("AspNetMenuPermission");

                mp.HasKey(l => new { l.RoleMenuId, l.PermissionId });

                mp.HasOne(o => o.Permission)
                    .WithMany(i => i.MenuPermissions)
                    .IsRequired();

                mp.HasOne(o => o.RoleMenu)
                    .WithMany(i => i.Permissions)
                    .IsRequired();
            });

            modelBuilder.Entity<Permission>(mp =>
            {
                mp.ToTable("AspNetPermission");

                mp.HasKey(l => l.Id);

                mp.HasMany(o => o.MenuPermissions)
                    .WithOne(i => i.Permission)
                    .HasForeignKey(y => y.PermissionId);
            });
        }
    }
}
