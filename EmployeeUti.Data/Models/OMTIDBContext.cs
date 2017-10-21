using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace EmployeeUti.Data.Models
{
    public partial class OMTIDBContext : DbContext
    {
        public virtual DbSet<AdmDepartment> AdmDepartment { get; set; }
        public virtual DbSet<AdmEmployee> AdmEmployee { get; set; }
        public virtual DbSet<AdmUser> AdmUser { get; set; }
        public virtual DbSet<AdmUserGroup> AdmUserGroup { get; set; }
        public virtual DbSet<AdmUserLevel> AdmUserLevel { get; set; }
        public virtual DbSet<AdmUserLevelHd> AdmUserLevelHd { get; set; }
        public virtual DbSet<BtsbusinessTripExpenseCategory> BtsbusinessTripExpenseCategory { get; set; }
        public virtual DbSet<BtsbusinessTripExpenseSubCategory> BtsbusinessTripExpenseSubCategory { get; set; }
        public virtual DbSet<BtsclaimStatus> BtsclaimStatus { get; set; }
        public virtual DbSet<Btsexpenses> Btsexpenses { get; set; }
        public virtual DbSet<TravelClaims> TravelClaims { get; set; }

        // Unable to generate entity type for table 'dbo.AdmUserOneTimePassword'. Please see the warning messages.

        public OMTIDBContext(DbContextOptions<OMTIDBContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AdmDepartment>(entity =>
            {
                entity.HasKey(e => e.DepartmentId);

                entity.Property(e => e.DepartmentId).HasDefaultValueSql("(0)");

                entity.Property(e => e.BranchId).HasDefaultValueSql("(0)");

                entity.Property(e => e.CreateBy)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasDefaultValueSql("(N'BTS')");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DepartmentCode)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DepartmentName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.EditBy)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.EditDate).HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasDefaultValueSql("(1)");

                entity.Property(e => e.IsSync).HasDefaultValueSql("(1)");

                entity.Property(e => e.IsSystem).HasDefaultValueSql("(0)");

                entity.Property(e => e.Remarks)
                    .IsRequired()
                    .HasColumnType("nvarchar(4000)")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SeqNo).HasDefaultValueSql("(0)");
            });

            modelBuilder.Entity<AdmEmployee>(entity =>
            {
                entity.HasKey(e => e.EmployeeId);

                entity.Property(e => e.EmployeeId).HasDefaultValueSql("(0)");

                entity.Property(e => e.BranchId).HasDefaultValueSql("(0)");

                entity.Property(e => e.CreateBy)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasDefaultValueSql("(N'BTS')");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DepartmentId).HasDefaultValueSql("(0)");

                entity.Property(e => e.EditBy)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.EditDate).HasColumnType("datetime");

                entity.Property(e => e.EmployeeCode)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.EmployeeName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.IsActive).HasDefaultValueSql("(1)");

                entity.Property(e => e.IsSync).HasDefaultValueSql("(1)");

                entity.Property(e => e.IsSystem).HasDefaultValueSql("(0)");

                entity.Property(e => e.Remarks)
                    .IsRequired()
                    .HasColumnType("nvarchar(4000)")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SeqNo).HasDefaultValueSql("(0)");

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.AdmEmployee)
                    .HasForeignKey(d => d.DepartmentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AdmEmployee_AdmDepartment");
            });

            modelBuilder.Entity<AdmUser>(entity =>
            {
                entity.HasKey(e => e.UserId);

                entity.Property(e => e.UserId).ValueGeneratedNever();

                entity.Property(e => e.ApplyToAll).HasDefaultValueSql("((0))");

                entity.Property(e => e.ApplyToAllBranches).HasDefaultValueSql("((0))");

                entity.Property(e => e.BranchId).HasDefaultValueSql("((0))");

                entity.Property(e => e.CreateBy)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasDefaultValueSql("(N'BTS')");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EditBy)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.EditDate).HasColumnType("datetime");

                entity.Property(e => e.EmployeeEmailId)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.EmployeeEmailPwd)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.EmployeeId).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.IsAuthenticationReq).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsEnableSsl).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsSync).HasDefaultValueSql("((1))");

                entity.Property(e => e.IsSystem).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsToAllowCustomisation).HasDefaultValueSql("((0))");

                entity.Property(e => e.LookAndFeel)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LookAndFeelId).HasDefaultValueSql("((0))");

                entity.Property(e => e.Password)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Remarks)
                    .IsRequired()
                    .HasColumnType("nvarchar(4000)")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Smtphost)
                    .IsRequired()
                    .HasColumnName("SMTPHost")
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Smtpport)
                    .HasColumnName("SMTPPort")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UserCode)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UserGroupId).HasDefaultValueSql("((0))");

                entity.Property(e => e.UserName)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ViewAllCustomers).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.UserGroup)
                    .WithMany(p => p.AdmUser)
                    .HasForeignKey(d => d.UserGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AdmUser_AdmUserGroup");
            });

            modelBuilder.Entity<AdmUserGroup>(entity =>
            {
                entity.HasKey(e => e.UserGroupId);

                entity.Property(e => e.UserGroupId).HasDefaultValueSql("((0))");

                entity.Property(e => e.BranchId).HasDefaultValueSql("((0))");

                entity.Property(e => e.CreateBy)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasDefaultValueSql("(N'BTS')");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EditBy)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.EditDate).HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.IsSync).HasDefaultValueSql("((1))");

                entity.Property(e => e.IsSystem).HasDefaultValueSql("((0))");

                entity.Property(e => e.Remarks)
                    .IsRequired()
                    .HasColumnType("nvarchar(4000)")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SeqNo).HasDefaultValueSql("((0))");

                entity.Property(e => e.UserGroupCode)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UserGroupName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ValidFrom)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<AdmUserLevel>(entity =>
            {
                entity.HasKey(e => new { e.UserLevelId, e.UserGroupId });

                entity.Property(e => e.UserLevelId).HasDefaultValueSql("((0))");

                entity.Property(e => e.UserGroupId).HasDefaultValueSql("((0))");

                entity.Property(e => e.ApprovalLimitAmt)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BranchId).HasDefaultValueSql("((0))");

                entity.Property(e => e.DaysToRetain).HasDefaultValueSql("((0))");

                entity.Property(e => e.DownwardUserGroupId).HasDefaultValueSql("((0))");

                entity.Property(e => e.ForwardUserGroupId).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsBegin).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsCanForwardToAnyLevel).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsEnd).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsIntermediate).HasDefaultValueSql("((0))");

                entity.Property(e => e.Remarks)
                    .IsRequired()
                    .HasColumnType("nvarchar(4000)")
                    .HasDefaultValueSql("('')");

                entity.HasOne(d => d.DownwardUserGroup)
                    .WithMany(p => p.AdmUserLevelDownwardUserGroup)
                    .HasForeignKey(d => d.DownwardUserGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AdmUserLevel_AdmUserGroup2");

                entity.HasOne(d => d.ForwardUserGroup)
                    .WithMany(p => p.AdmUserLevelForwardUserGroup)
                    .HasForeignKey(d => d.ForwardUserGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AdmUserLevel_AdmUserGroup1");

                entity.HasOne(d => d.UserGroup)
                    .WithMany(p => p.AdmUserLevelUserGroup)
                    .HasForeignKey(d => d.UserGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AdmUserLevel_AdmUserGroup");

                entity.HasOne(d => d.UserLevel)
                    .WithMany(p => p.AdmUserLevel)
                    .HasForeignKey(d => d.UserLevelId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AdmUserLevel_AdmUserLevelHd");
            });

            modelBuilder.Entity<AdmUserLevelHd>(entity =>
            {
                entity.HasKey(e => e.UserLevelId);

                entity.Property(e => e.UserLevelId).HasDefaultValueSql("((0))");

                entity.Property(e => e.BranchId).HasDefaultValueSql("((0))");

                entity.Property(e => e.CreateBy)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasDefaultValueSql("(N'BTS')");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EditBy)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.EditDate).HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.IsSync).HasDefaultValueSql("((1))");

                entity.Property(e => e.IsSystem).HasDefaultValueSql("((0))");

                entity.Property(e => e.ModuleId).HasDefaultValueSql("((0))");

                entity.Property(e => e.TransactionId).HasDefaultValueSql("((0))");

                entity.Property(e => e.UserLevelCode)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UserLevelName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<BtsbusinessTripExpenseCategory>(entity =>
            {
                entity.HasKey(e => e.CategoryId);

                entity.ToTable("BTSBusinessTripExpenseCategory");

                entity.Property(e => e.CategoryName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedBy).HasColumnType("nchar(10)");

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasColumnType("nchar(10)");

                entity.Property(e => e.ModifiedTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<BtsbusinessTripExpenseSubCategory>(entity =>
            {
                entity.HasKey(e => e.SubCategoryId);

                entity.ToTable("BTSBusinessTripExpenseSubCategory");

                entity.Property(e => e.SubCategoryId).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnType("nchar(10)");

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(50);

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasColumnType("nchar(10)");

                entity.Property(e => e.ModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.SubCategoryName)
                    .IsRequired()
                    .HasColumnType("nchar(10)");

                entity.Property(e => e.ValidFrom).HasColumnType("datetime");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.BtsbusinessTripExpenseSubCategory)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK_BTSBusinessTripExpenseCategory_CategoryId");
            });

            modelBuilder.Entity<BtsclaimStatus>(entity =>
            {
                entity.HasKey(e => e.StatusId);

                entity.ToTable("BTSClaimStatus");

                entity.Property(e => e.StatusId).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).HasColumnType("datetime");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.StatusName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Btsexpenses>(entity =>
            {
                entity.HasKey(e => e.ExpenseId);

                entity.ToTable("BTSExpenses");

                entity.Property(e => e.ExpenseAmount).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.ExpenseEndDate).HasColumnType("datetime");

                entity.Property(e => e.ExpenseStartDate).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy).HasColumnType("datetime");

                entity.HasOne(d => d.Claim)
                    .WithMany(p => p.Btsexpenses)
                    .HasForeignKey(d => d.ClaimId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TravelClaims_ID");

                entity.HasOne(d => d.ExpenseCategory)
                    .WithMany(p => p.Btsexpenses)
                    .HasForeignKey(d => d.ExpenseCategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BTSBusinessExpenseCategory");

                entity.HasOne(d => d.ExpenseSubCategory)
                    .WithMany(p => p.Btsexpenses)
                    .HasForeignKey(d => d.ExpenseSubCategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BTSBusinessTripExpenseSubCategory");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.Btsexpenses)
                    .HasForeignKey(d => d.StatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BTSStatus");
            });

            modelBuilder.Entity<TravelClaims>(entity =>
            {
                entity.HasKey(e => e.ClaimId);

                entity.Property(e => e.BusinessPurpose)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Destination)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.EnterTime).HasColumnType("datetime");

                entity.Property(e => e.ModifieTime).HasColumnType("datetime");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.TravelClaims)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TravelClaims_LastVerifiedDate");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.TravelClaims)
                    .HasForeignKey(d => d.StatusId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_TravelClaims_StatusId1");
            });
        }
    }
}
