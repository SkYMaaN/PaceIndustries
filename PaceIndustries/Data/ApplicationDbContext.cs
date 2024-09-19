using Microsoft.EntityFrameworkCore;
using PaceIndustries.Data.Entities;

namespace PaceIndustries.Data;

public partial class ApplicationDbContext : DbContext
{
    public ApplicationDbContext()
    {
    }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Apopen> Apopens { get; set; }

    public virtual DbSet<Contact> Contacts { get; set; }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<ForecastDtl> ForecastDtls { get; set; }

    public virtual DbSet<OrderDate> OrderDates { get; set; }

    public virtual DbSet<OrderHeader> OrderHeaders { get; set; }

    public virtual DbSet<OrderItem> OrderItems { get; set; }

    public virtual DbSet<PSupplierAck> PSupplierAcks { get; set; }

    public virtual DbSet<Period> Periods { get; set; }

    public virtual DbSet<Plant> Plants { get; set; }

    public virtual DbSet<Podate> Podates { get; set; }

    public virtual DbSet<Poheader> Poheaders { get; set; }

    public virtual DbSet<Poitem> Poitems { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<Pw> Pws { get; set; }

    public virtual DbSet<SalesHistoryDtl> SalesHistoryDtls { get; set; }

    public virtual DbSet<ShipTo> ShipTos { get; set; }

    public virtual DbSet<Supplier> Suppliers { get; set; }

    public virtual DbSet<SupplierX> SupplierXes { get; set; }

    public virtual DbSet<SupplierXdailyParent> SupplierXdailyParents { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Apopen>(entity =>
        {
            entity.HasKey(e => e.OdyUniqueId).HasName("PK__APOpen__CB124769EA95A458");

            entity.ToTable("APOpen", tb => tb.HasTrigger("TRG_APOpen_UpdateDate"));

            entity.Property(e => e.OdyUniqueId).ValueGeneratedNever();
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.UpdateTimeStamp).HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.Company).WithMany(p => p.Apopens)
                .HasPrincipalKey(p => p.CompanyId)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__APOpen__CompanyI__43987E1A");

            entity.HasOne(d => d.Supplier).WithMany(p => p.Apopens)
                .HasPrincipalKey(p => new { p.SupplierId, p.CompanyId })
                .HasForeignKey(d => new { d.SupplierId, d.CompanyId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("con_fk_apopen_supplier");
        });

        modelBuilder.Entity<Contact>(entity =>
        {
            entity.HasKey(e => e.OdyUniqueId).HasName("PK__Contact__CB12476952575B77");

            entity.ToTable("Contact", tb => tb.HasTrigger("TRG_Contact_UpdateDate"));

            entity.Property(e => e.OdyUniqueId).ValueGeneratedNever();
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.UpdateTimeStamp).HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.ParentCompany).WithMany(p => p.Contacts)
                .HasPrincipalKey(p => p.CompanyId)
                .HasForeignKey(d => d.ParentCompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Contact__ParentC__3ED3C8FD");
        });

        modelBuilder.Entity<Customer>(entity =>
        {
            entity.HasKey(e => e.OdyUniqueId).HasName("PK__Customer__CB12476942F2C78D");

            entity.ToTable("Customer", tb => tb.HasTrigger("TRG_Customer_UpdateDate"));

            entity.Property(e => e.OdyUniqueId).ValueGeneratedNever();
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.UpdateTimeStamp).HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.Company).WithMany(p => p.Customers)
                .HasPrincipalKey(p => p.CompanyId)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Customer__Compan__4A457BA9");
        });

        modelBuilder.Entity<ForecastDtl>(entity =>
        {
            entity.HasKey(e => e.OdyUniqueId).HasName("PK__Forecast__CB1247691F8EF91B");

            entity.ToTable("ForecastDtl", tb => tb.HasTrigger("TRG_ForecastDtl_UpdateDate"));

            entity.Property(e => e.OdyUniqueId).ValueGeneratedNever();
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.UpdateTimeStamp).HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.Customer).WithMany(p => p.ForecastDtls)
                .HasPrincipalKey(p => new { p.CustomerId, p.CompanyId })
                .HasForeignKey(d => new { d.CustomerId, d.CompanyId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("con_fk_forecastdtl_customer");

            entity.HasOne(d => d.PeriodNavigation).WithMany(p => p.ForecastDtls)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("con_fk_forecastdtl_period");

            entity.HasOne(d => d.Product).WithMany(p => p.ForecastDtls)
                .HasPrincipalKey(p => new { p.ProductId, p.CompanyId })
                .HasForeignKey(d => new { d.ProductId, d.CompanyId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("con_fk_forecastdtl_product");
        });

        modelBuilder.Entity<OrderDate>(entity =>
        {
            entity.HasKey(e => e.OdyUniqueId).HasName("PK__OrderDat__CB124769EC37C03D");

            entity.ToTable("OrderDate", tb => tb.HasTrigger("TRG_OrderDate_UpdateDate"));

            entity.Property(e => e.OdyUniqueId).ValueGeneratedNever();
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.UpdateTimeStamp).HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.Customer).WithMany(p => p.OrderDates)
                .HasPrincipalKey(p => new { p.CustomerId, p.CompanyId })
                .HasForeignKey(d => new { d.CustomerId, d.CompanyId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("con_fk_orderdate_customer");

            entity.HasOne(d => d.Product).WithMany(p => p.OrderDates)
                .HasPrincipalKey(p => new { p.ProductId, p.CompanyId })
                .HasForeignKey(d => new { d.ProductId, d.CompanyId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("con_fk_orderdate_product");

            entity.HasOne(d => d.ShipToNavigation).WithMany(p => p.OrderDates)
                .HasPrincipalKey(p => new { p.OdyShipToId, p.CompanyId })
                .HasForeignKey(d => new { d.ShipTo, d.CompanyId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("con_fk_orderdate_shipto");

            entity.HasOne(d => d.OrderItemNavigation).WithMany(p => p.OrderDates)
                .HasPrincipalKey(p => new { p.OrderNumber, p.OrderItem1, p.CompanyId })
                .HasForeignKey(d => new { d.OrderNumber, d.OrderItem, d.CompanyId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("con_fk_orderdate_orderitem");
        });

        modelBuilder.Entity<OrderHeader>(entity =>
        {
            entity.HasKey(e => e.OdyUniqueId).HasName("PK__OrderHea__CB1247694FF051A1");

            entity.ToTable("OrderHeader", tb => tb.HasTrigger("TRG_OrderHeader_UpdateDate"));

            entity.Property(e => e.OdyUniqueId).ValueGeneratedNever();
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.UpdateTimeStamp).HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.Company).WithMany(p => p.OrderHeaders)
                .HasPrincipalKey(p => p.CompanyId)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__OrderHead__Compa__6D8EB7E6");

            entity.HasOne(d => d.Customer).WithMany(p => p.OrderHeaders)
                .HasPrincipalKey(p => new { p.CustomerId, p.CompanyId })
                .HasForeignKey(d => new { d.CustomerId, d.CompanyId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("con_fk_orderheader_customer");

            entity.HasOne(d => d.ShipToNavigation).WithMany(p => p.OrderHeaders)
                .HasPrincipalKey(p => new { p.OdyShipToId, p.CompanyId })
                .HasForeignKey(d => new { d.ShipTo, d.CompanyId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("con_fk_orderheader_shipto");
        });

        modelBuilder.Entity<OrderItem>(entity =>
        {
            entity.HasKey(e => e.OdyUniqueId).HasName("PK__OrderIte__CB124769971C1137");

            entity.ToTable("OrderItem", tb => tb.HasTrigger("TRG_OrderItem_UpdateDate"));

            entity.Property(e => e.OdyUniqueId).ValueGeneratedNever();
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.UpdateTimeStamp).HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.OrderHeader).WithMany(p => p.OrderItems)
                .HasPrincipalKey(p => new { p.OrderNumber, p.CompanyId })
                .HasForeignKey(d => new { d.OrderNumber, d.CompanyId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("con_fk_orderitem_orderheader");

            entity.HasOne(d => d.Product).WithMany(p => p.OrderItems)
                .HasPrincipalKey(p => new { p.ProductId, p.CompanyId })
                .HasForeignKey(d => new { d.ProductId, d.CompanyId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("con_fk_orderitem_product");
        });

        modelBuilder.Entity<PSupplierAck>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__pSupplie__3214EC0795CA79E0");
        });

        modelBuilder.Entity<Period>(entity =>
        {
            entity.HasKey(e => new { e.PeriodNumber, e.Year }).HasName("con_pk_period");

            entity.ToTable("Period", tb => tb.HasTrigger("TRG_Period_UpdateDate"));

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.UpdateTimeStamp).HasDefaultValueSql("(getdate())");
        });

        modelBuilder.Entity<Plant>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Plant__3214EC07CAA2B3FB");

            entity.ToTable("Plant", tb => tb.HasTrigger("TRG_Plant_UpdateDate"));

            entity.Property(e => e.UpdateTimeStamp).HasDefaultValueSql("(getdate())");
        });

        modelBuilder.Entity<Podate>(entity =>
        {
            entity.HasKey(e => e.OdyUniqueId).HasName("PK__PODate__CB1247693707AE3C");

            entity.ToTable("PODate", tb => tb.HasTrigger("TRG_PODate_UpdateDate"));

            entity.Property(e => e.OdyUniqueId).ValueGeneratedNever();
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.UpdateTimeStamp).HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.Company).WithMany(p => p.Podates)
                .HasPrincipalKey(p => p.CompanyId)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__PODate__CompanyI__40870745");

            entity.HasOne(d => d.PoitemNavigation).WithMany(p => p.Podates)
                .HasPrincipalKey(p => new { p.Ponumber, p.Poitem1, p.CompanyId })
                .HasForeignKey(d => new { d.Ponumber, d.Poitem, d.CompanyId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("con_fk_podate_poitem");
        });

        modelBuilder.Entity<Poheader>(entity =>
        {
            entity.HasKey(e => e.OdyUniqueId).HasName("PK__POHeader__CB124769DC9C43B2");

            entity.ToTable("POHeader", tb => tb.HasTrigger("TRG_POHeader_UpdateDate"));

            entity.Property(e => e.OdyUniqueId).ValueGeneratedNever();
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.UpdateTimeStamp).HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.Company).WithMany(p => p.Poheaders)
                .HasPrincipalKey(p => p.CompanyId)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__POHeader__Compan__3238E7EE");

            entity.HasOne(d => d.Supplier).WithMany(p => p.Poheaders)
                .HasPrincipalKey(p => new { p.SupplierId, p.CompanyId })
                .HasForeignKey(d => new { d.SupplierId, d.CompanyId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("con_fk_poheader_supplier");
        });

        modelBuilder.Entity<Poitem>(entity =>
        {
            entity.HasKey(e => e.OdyUniqueId).HasName("PK__POItem__CB124769D1202872");

            entity.ToTable("POItem", tb => tb.HasTrigger("TRG_POItem_UpdateDate"));

            entity.Property(e => e.OdyUniqueId).ValueGeneratedNever();
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.UpdateTimeStamp).HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.Company).WithMany(p => p.Poitems)
                .HasPrincipalKey(p => p.CompanyId)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__POItem__CompanyI__38E5E57D");

            entity.HasOne(d => d.Poheader).WithMany(p => p.Poitems)
                .HasPrincipalKey(p => new { p.Ponumber, p.CompanyId })
                .HasForeignKey(d => new { d.Ponumber, d.CompanyId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("con_fk_poitem_poheader");

            entity.HasOne(d => d.Supplier).WithMany(p => p.Poitems)
                .HasPrincipalKey(p => new { p.SupplierId, p.CompanyId })
                .HasForeignKey(d => new { d.SupplierId, d.CompanyId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("con_fk_poitem_supplier");
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.OdyUniqueId).HasName("PK__Product__CB1247690CBA7E3B");

            entity.ToTable("Product", tb => tb.HasTrigger("TRG_Product_UpdateDate"));

            entity.Property(e => e.OdyUniqueId).ValueGeneratedNever();
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.UpdateTimeStamp).HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.Company).WithMany(p => p.Products)
                .HasPrincipalKey(p => p.CompanyId)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Product__Company__56AB528E");

            entity.HasOne(d => d.Customer).WithMany(p => p.Products)
                .HasPrincipalKey(p => new { p.CustomerId, p.CompanyId })
                .HasForeignKey(d => new { d.CustomerId, d.CompanyId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("con_fk_product_customer");
        });

        modelBuilder.Entity<Pw>(entity =>
        {
            entity.HasKey(e => e.PwId).HasName("PK__PW__6361ECA1F193AA42");

            entity.Property(e => e.CreatedAt).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.UpdatedAt).HasDefaultValueSql("(getdate())");
        });

        modelBuilder.Entity<SalesHistoryDtl>(entity =>
        {
            entity.HasKey(e => e.OdyUniqueId).HasName("PK__SalesHis__CB1247699DEDD8A1");

            entity.ToTable("SalesHistoryDtl", tb => tb.HasTrigger("TRG_SalesHistoryDtl_UpdateDate"));

            entity.Property(e => e.OdyUniqueId).ValueGeneratedNever();
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.UpdateTimeStamp).HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.Customer).WithMany(p => p.SalesHistoryDtls)
                .HasPrincipalKey(p => new { p.CustomerId, p.CompanyId })
                .HasForeignKey(d => new { d.CustomerId, d.CompanyId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("con_fk_saleshistorydtl_customer");

            entity.HasOne(d => d.PeriodNavigation).WithMany(p => p.SalesHistoryDtls)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("con_fk_saleshistorydtl_period");

            entity.HasOne(d => d.Product).WithMany(p => p.SalesHistoryDtls)
                .HasPrincipalKey(p => new { p.ProductId, p.CompanyId })
                .HasForeignKey(d => new { d.ProductId, d.CompanyId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("con_fk_saleshistorydtl_product");

            entity.HasOne(d => d.ShipToNavigation).WithMany(p => p.SalesHistoryDtls)
                .HasPrincipalKey(p => new { p.OdyShipToId, p.CompanyId })
                .HasForeignKey(d => new { d.ShipTo, d.CompanyId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("con_fk_saleshistorydtl_shipto");
        });

        modelBuilder.Entity<ShipTo>(entity =>
        {
            entity.HasKey(e => e.OdyUniqueId).HasName("PK__ShipTo__CB12476981917B29");

            entity.ToTable("ShipTo", tb => tb.HasTrigger("TRG_ShipTo_UpdateDate"));

            entity.Property(e => e.OdyUniqueId).ValueGeneratedNever();
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.UpdateTimeStamp).HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.Company).WithMany(p => p.ShipTos)
                .HasPrincipalKey(p => p.CompanyId)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__ShipTo__CompanyI__4FFE54FF");

            entity.HasOne(d => d.Customer).WithMany(p => p.ShipTos)
                .HasPrincipalKey(p => new { p.CustomerId, p.CompanyId })
                .HasForeignKey(d => new { d.CustomerId, d.CompanyId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("con_fk_shipto_customer");
        });

        modelBuilder.Entity<Supplier>(entity =>
        {
            entity.HasKey(e => e.OdyUniqueId).HasName("PK__Supplier__CB12476961B4ECDA");

            entity.ToTable("Supplier", tb => tb.HasTrigger("TRG_Supplier_UpdateDate"));

            entity.Property(e => e.OdyUniqueId).ValueGeneratedNever();
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.UpdateTimeStamp).HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.Company).WithMany(p => p.Suppliers)
                .HasPrincipalKey(p => p.CompanyId)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Supplier__Compan__354A5EC3");
        });

        modelBuilder.Entity<SupplierX>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Supplier__3214EC0783832C0F");

            entity.ToTable("SupplierX", tb => tb.HasTrigger("TRG_SupplierX_UpdateDate"));

            entity.Property(e => e.UpdateTimeStamp).HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.Parent).WithMany(p => p.SupplierXes)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__SupplierX__Paren__50BD6F0E");
        });

        modelBuilder.Entity<SupplierXdailyParent>(entity =>
        {
            entity.HasOne(d => d.Parent).WithMany()
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__SupplierX__Paren__56764864");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
