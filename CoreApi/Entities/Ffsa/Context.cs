using CoreApi.Models.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace CoreApi.Entities
{
    public class Context : DbContext
    {
        private readonly EnvironmentConfig _environmentConfig;

        public Context(DbContextOptions<Context> options, IOptions<EnvironmentConfig> environmentConfig) : base(options)
        {
            _environmentConfig = environmentConfig.Value;
        }

        public virtual DbSet<AcademicHistory> AcademicHistories { get; set; }
        public virtual DbSet<Address> Addresses { get; set; }
        public virtual DbSet<ApplicantDeclaration> ApplicantDeclarations { get; set; }
        public virtual DbSet<Application> Applications { get; set; }
        public virtual DbSet<BenifactorDeclaration> BenifactorDeclarations { get; set; }
        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<CourseCertificate> CourseCertificates { get; set; }
        public virtual DbSet<CourseDuration> CourseDurations { get; set; }
        public virtual DbSet<CourseSchedule> CourseSchedules { get; set; }
        public virtual DbSet<CourseSyllabus> CourseSyllabus { get; set; }
        public virtual DbSet<CourseTechnicalSample> CourseTechnicalSamples { get; set; }
        public virtual DbSet<Declaration> Declarations { get; set; }
        public virtual DbSet<Fees> Fees { get; set; }
        public virtual DbSet<HighSchoolRecord> HighSchoolRecords { get; set; }
        public virtual DbSet<HighSchoolSeniorCertificate> HighSchoolSeniorCertificates { get; set; }
        public virtual DbSet<Marketing> Marketing { get; set; }
        public virtual DbSet<MarketingMedia> MarketingPlatforms { get; set; }
        public virtual DbSet<MarketingMediaGuidanceConsellor> MarketingMediaGuidanceConsellors { get; set; }
        public virtual DbSet<ParentOrGuardianDetails> ParentOrGuardianDetails { get; set; }
        public virtual DbSet<Signature> Signatures { get; set; }
        public virtual DbSet<StudentDetails> StudentDetails { get; set; }
        public virtual DbSet<TertiaryYearRecord> TertiaryYearRecords { get; set; }
        public virtual DbSet<TertiaryStudyRecord> TertiaryStudyRecords { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AcademicHistory>(entity =>
            {
                entity.ToTable("AcademicHistory",  _environmentConfig.Database);

                entity.HasIndex(e => e.HighSchoolRecordId)
                    .HasName("FK_AcademicHistory_HighSchoolRecord");

                entity.HasIndex(e => e.TertiaryStudyRecordId)
                    .HasName("FK_AcademicHistory_TertiaryStudyRecord");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.HighSchoolRecordId)
                    .HasColumnName("HighSchoolRecordID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TertiaryStudyRecordId)
                    .HasColumnName("TertiaryStudyRecordID")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<Address>(entity =>
            {
                entity.ToTable("Address",  _environmentConfig.Database);

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Line1)
                    .HasColumnName("line1")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Line2)
                    .HasColumnName("line2")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Line3)
                    .HasColumnName("line3")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PostalCode)
                    .HasColumnName("postalCode")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<ApplicantDeclaration>(entity =>
            {
                entity.ToTable("ApplicantDeclaration",  _environmentConfig.Database);

                entity.HasIndex(e => e.ApplicantSignatureId)
                    .HasName("FK_ApplicantDeclaration_ApplicantSignature");

                entity.HasIndex(e => e.WitnessSignatureId)
                    .HasName("FK_ApplicantDeclaration_WitnessSignature");

                entity.HasIndex(e => e.WitnessSignatureId)
                    .HasName("FK_ApplicantDeclaration_ParentOrGuardianDetailsSignature");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ApplicantSignatureId)
                    .HasColumnName("ApplicantSignatureID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FullName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IdorPassportNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.WitnessSignatureId)
                    .HasColumnName("WitnessSignatureID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ParentOrGuardianDetailsSignatureId)
                    .HasColumnName("ParentOrGuardianDetailsSignatureID")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<Application>(entity =>
            {
                entity.ToTable("Application",  _environmentConfig.Database);

                entity.HasIndex(e => e.AcademicHistoryId)
                    .HasName("FK_Application_AcademicHistory");

                entity.HasIndex(e => e.CourseId)
                    .HasName("FK_Application_Course");

                entity.HasIndex(e => e.DeclarationId)
                    .HasName("FK_Application_Declaration");

                entity.HasIndex(e => e.MarketingId)
                    .HasName("FK_Application_Marketing");

                entity.HasIndex(e => e.ParentOrGuardianDetailsId)
                    .HasName("FK_Application_ParentOrGuardianDetails");

                entity.HasIndex(e => e.StudentDetailsId)
                    .HasName("FK_Application_StudentDetails");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AcademicHistoryId)
                    .HasColumnName("AcademicHistoryID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CourseId)
                    .HasColumnName("CourseID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.DeclarationId)
                    .HasColumnName("DeclarationID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MarketingId)
                    .HasColumnName("MarketingID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ParentOrGuardianDetailsId)
                    .HasColumnName("ParentOrGuardianDetailsID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.StudentDetailsId)
                    .HasColumnName("StudentDetailsID")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<BenifactorDeclaration>(entity =>
            {
                entity.ToTable("BenifactorDeclaration",  _environmentConfig.Database);

                entity.HasIndex(e => e.SignatureId)
                    .HasName("FK_BenifactorDeclaration_Signature");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FullName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Idnumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SignatureId)
                    .HasColumnName("SignatureID")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<Course>(entity =>
            {
                entity.ToTable("Course",  _environmentConfig.Database);

                entity.HasIndex(e => e.CertificateTypeId)
                    .HasName("FK_Course_CertificateType");

                entity.HasIndex(e => e.CourseDurationId)
                    .HasName("FK_Course_CourseDuration");

                entity.HasIndex(e => e.CourseDurationTypeId)
                    .HasName("FK_Course_CourseDurationType");

                entity.HasIndex(e => e.CourseScheduleId)
                    .HasName("FK_Course_CourseSchedule");

                entity.HasIndex(e => e.CourseSyllabusId)
                    .HasName("FK_Course_CourseSyllabus");

                entity.HasIndex(e => e.CourseTechnicalSampleId)
                    .HasName("FK_Course_CourseTechnicalSample");

                entity.HasIndex(e => e.FeesId)
                    .HasName("FK_Course_Fees");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CertificateTypeId)
                    .HasColumnName("CertificateTypeID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CourseDurationId)
                    .HasColumnName("CourseDurationID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CourseDurationTypeId)
                    .HasColumnName("CourseDurationTypeID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CourseScheduleId)
                    .HasColumnName("CourseScheduleID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CourseSyllabusId)
                    .HasColumnName("CourseSyllabusID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CourseTechnicalSampleId)
                    .HasColumnName("CourseTechnicalSampleID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FeesId)
                    .HasColumnName("FeesID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CourseCertificate>(entity =>
            {
                entity.ToTable("CourseCertificate",  _environmentConfig.Database);

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CourseDuration>(entity =>
            {
                entity.ToTable("CourseDuration",  _environmentConfig.Database);

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CourseSchedule>(entity =>
            {
                entity.ToTable("CourseSchedule",  _environmentConfig.Database);

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CourseSyllabus>(entity =>
            {
                entity.ToTable("CourseSyllabus",  _environmentConfig.Database);

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(5000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CourseTechnicalSample>(entity =>
            {
                entity.ToTable("CourseTechnicalSample",  _environmentConfig.Database);

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(2000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Declaration>(entity =>
            {
                entity.ToTable("Declaration",  _environmentConfig.Database);

                entity.HasIndex(e => e.ApplicantDeclarationId)
                    .HasName("FK_Declaration_ApplicantDeclaration");

                entity.HasIndex(e => e.BenifactorDeclarationId)
                    .HasName("FK_Declaration_BenifactorDeclaration");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ApplicantDeclarationId)
                    .HasColumnName("ApplicantDeclarationID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.BenifactorDeclarationId)
                    .HasColumnName("BenifactorDeclarationID")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<Fees>(entity =>
            {
                entity.ToTable("Fees",  _environmentConfig.Database);

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Amount).HasColumnType("int(11)");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<HighSchoolRecord>(entity =>
            {
                entity.ToTable("HighSchoolRecord",  _environmentConfig.Database);

                entity.HasIndex(e => e.HighSchoolSeniorCertificateId)
                    .HasName("FK_Course_HighSchoolSeniorCertificate");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Aggregate)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Country)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.HighSchoolSeniorCertificateId)
                    .HasColumnName("HighSchoolSeniorCertificateID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.LasHighSchoolAttended)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Year).HasColumnType("int(11)");
            });

            modelBuilder.Entity<HighSchoolSeniorCertificate>(entity =>
            {
                entity.ToTable("HighSchoolSeniorCertificate",  _environmentConfig.Database);

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Marketing>(entity =>
            {
                entity.ToTable("Marketing",  _environmentConfig.Database);

                entity.HasIndex(e => e.GuidanceConsellorId)
                    .HasName("FK_StudentDetails_GuidanceConsellor");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.GuidanceConsellorId)
                    .HasColumnName("GuidanceConsellorID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MarketingMediaId)
                    .HasColumnName("MarketingMediaID")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<MarketingMedia>(entity =>
            {
                entity.ToTable("MarketingMedia",  _environmentConfig.Database);

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MarketingMediaGuidanceConsellor>(entity =>
            {
                entity.ToTable("MarketingMediaGuidanceConsellor",  _environmentConfig.Database);

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Contact)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ParentOrGuardianDetails>(entity =>
            {
                entity.ToTable("ParentOrGuardianDetails",  _environmentConfig.Database);

                entity.HasIndex(e => e.PostalAddressId)
                    .HasName("FK_Course_PostalAddress");

                entity.HasIndex(e => e.ResidentialAddressId)
                    .HasName("FK_Course_ResidentialAddress");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Cell)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Idnumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PostalAddressId)
                    .HasColumnName("PostalAddressID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Relationship)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ResidentialAddressId)
                    .HasColumnName("ResidentialAddressID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TelHome)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.TelWork)
                    .HasMaxLength(25)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Signature>(entity =>
            {
                entity.ToTable("Signature",  _environmentConfig.Database);

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Date)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.SignatureInitials)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<StudentDetails>(entity =>
            {
                entity.ToTable("StudentDetails",  _environmentConfig.Database);

                entity.HasIndex(e => e.PostalAddressId)
                    .HasName("FK_StudentDetails_PostalAddress");

                entity.HasIndex(e => e.ResidentialAddressId)
                    .HasName("FK_StudentDetails_ResidentialAddress");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Cell)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.DisabilitiesOrMedicalConditionAffectStudies)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fax)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.FirstNames)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Gander)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Idnumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NatureOfDisabilityOrMedicalCondition)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.OtherRace)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PostalAddressId)
                    .HasColumnName("PostalAddressID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Race)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ResidentialAddressId)
                    .HasColumnName("ResidentialAddressID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Surname)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TelHome)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.TelWork)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TertiaryYearRecord>(entity =>
            {
                entity.ToTable("TertiaryYearRecord",  _environmentConfig.Database);

                entity.HasIndex(e => e.CompletedId)
                    .HasName("FK_TertiaryYearRecord_Completed");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CompletedId)
                    .HasColumnName("CompletedID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Institution)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.QualificationDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TotalCredits).HasColumnType("int(11)");

                entity.Property(e => e.YearsOfStudy).HasColumnType("int(11)");
            });

            modelBuilder.Entity<TertiaryStudyRecord>(entity =>
            {
                entity.ToTable("TertiaryStudyRecord", _environmentConfig.Database);

                entity.HasIndex(e => e.TertiaryYear1RecordId)
                    .HasName("FK_TertiaryYearRecord_TertiaryYear1Record");

                entity.HasIndex(e => e.TertiaryYear2RecordId)
                    .HasName("FK_TertiaryYearRecord_TertiaryYear2Record");

                entity.HasIndex(e => e.TertiaryYear3RecordId)
                    .HasName("FK_TertiaryYearRecord_TertiaryYear3Record");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TertiaryYear1RecordId)
                    .HasColumnName("TertiaryYear1RecordID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TertiaryYear2RecordId)
                    .HasColumnName("TertiaryYear2RecordID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TertiaryYear3RecordId)
                    .HasColumnName("TertiaryYear3RecordID")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("User",  _environmentConfig.Database);

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });
        }
    }
}