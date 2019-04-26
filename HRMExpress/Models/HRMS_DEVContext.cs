using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using HRMExpress.Models.Mapping;

namespace HRMExpress.Models
{
    public partial class HRMS_DEVContext : DbContext
    {
        static HRMS_DEVContext()
        {
            Database.SetInitializer<HRMS_DEVContext>(null);
        }

        public HRMS_DEVContext()
            : base("Name=HRMS_DEVContext")
        {
        }

        public DbSet<Address> Addresses { get; set; }
        public DbSet<Appraisal> Appraisals { get; set; }
        public DbSet<AppraisalMessage> AppraisalMessages { get; set; }
        public DbSet<AppraisalReview> AppraisalReviews { get; set; }
        public DbSet<AppraisalTemplate> AppraisalTemplates { get; set; }
        public DbSet<Attendance> Attendances { get; set; }
        public DbSet<Candidate> Candidates { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<CompanyMaster> CompanyMasters { get; set; }
        public DbSet<CoreValue> CoreValues { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<DeveIdea> DeveIdeas { get; set; }
        public DbSet<Division> Divisions { get; set; }
        public DbSet<Document> Documents { get; set; }
        public DbSet<EmpFamilyMember> EmpFamilyMembers { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<EmployeeDocument> EmployeeDocuments { get; set; }
        public DbSet<EmployeeRole> EmployeeRoles { get; set; }
        public DbSet<Experiance> Experiances { get; set; }
        public DbSet<Interview> Interviews { get; set; }
        public DbSet<JobType> JobTypes { get; set; }
        public DbSet<LeaveMaster> LeaveMasters { get; set; }
        public DbSet<LeaveTransaction> LeaveTransactions { get; set; }
        public DbSet<LeaveType> LeaveTypes { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<Objective> Objectives { get; set; }
        public DbSet<Platform> Platforms { get; set; }
        public DbSet<Qualification> Qualifications { get; set; }
        public DbSet<Requirement> Requirements { get; set; }
        public DbSet<RequirementAssignment> RequirementAssignments { get; set; }
        public DbSet<RequirementComment> RequirementComments { get; set; }
        public DbSet<RequirementFlow> RequirementFlows { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<State> States { get; set; }
        public DbSet<sysdiagram> sysdiagrams { get; set; }
        public DbSet<SystemParameter> SystemParameters { get; set; }
        public DbSet<Technology> Technologies { get; set; }
        public DbSet<TrainingDetail> TrainingDetails { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<AppraisalDetail> AppraisalDetails { get; set; }
        public DbSet<AppraisalRev> AppraisalRevs { get; set; }
        public DbSet<Employee_Appraisal> Employee_Appraisal { get; set; }
        public DbSet<MyEMployee> MyEMployees { get; set; }
        public DbSet<ReceivedRequirement> ReceivedRequirements { get; set; }
        public DbSet<RegisteredUser> RegisteredUsers { get; set; }
        public DbSet<RequirementDetail> RequirementDetails { get; set; }
        public DbSet<RequirementDetails_t> RequirementDetails_t { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AddressMap());
            modelBuilder.Configurations.Add(new AppraisalMap());
            modelBuilder.Configurations.Add(new AppraisalMessageMap());
            modelBuilder.Configurations.Add(new AppraisalReviewMap());
            modelBuilder.Configurations.Add(new AppraisalTemplateMap());
            modelBuilder.Configurations.Add(new AttendanceMap());
            modelBuilder.Configurations.Add(new CandidateMap());
            modelBuilder.Configurations.Add(new CityMap());
            modelBuilder.Configurations.Add(new CompanyMap());
            modelBuilder.Configurations.Add(new CompanyMasterMap());
            modelBuilder.Configurations.Add(new CoreValueMap());
            modelBuilder.Configurations.Add(new CountryMap());
            modelBuilder.Configurations.Add(new DepartmentMap());
            modelBuilder.Configurations.Add(new DeveIdeaMap());
            modelBuilder.Configurations.Add(new DivisionMap());
            modelBuilder.Configurations.Add(new DocumentMap());
            modelBuilder.Configurations.Add(new EmpFamilyMemberMap());
            modelBuilder.Configurations.Add(new EmployeeMap());
            modelBuilder.Configurations.Add(new EmployeeDocumentMap());
            modelBuilder.Configurations.Add(new EmployeeRoleMap());
            modelBuilder.Configurations.Add(new ExperianceMap());
            modelBuilder.Configurations.Add(new InterviewMap());
            modelBuilder.Configurations.Add(new JobTypeMap());
            modelBuilder.Configurations.Add(new LeaveMasterMap());
            modelBuilder.Configurations.Add(new LeaveTransactionMap());
            modelBuilder.Configurations.Add(new LeaveTypeMap());
            modelBuilder.Configurations.Add(new MenuMap());
            modelBuilder.Configurations.Add(new ObjectiveMap());
            modelBuilder.Configurations.Add(new PlatformMap());
            modelBuilder.Configurations.Add(new QualificationMap());
            modelBuilder.Configurations.Add(new RequirementMap());
            modelBuilder.Configurations.Add(new RequirementAssignmentMap());
            modelBuilder.Configurations.Add(new RequirementCommentMap());
            modelBuilder.Configurations.Add(new RequirementFlowMap());
            modelBuilder.Configurations.Add(new RoleMap());
            modelBuilder.Configurations.Add(new StateMap());
            modelBuilder.Configurations.Add(new sysdiagramMap());
            modelBuilder.Configurations.Add(new SystemParameterMap());
            modelBuilder.Configurations.Add(new TechnologyMap());
            modelBuilder.Configurations.Add(new TrainingDetailMap());
            modelBuilder.Configurations.Add(new UserMap());
            modelBuilder.Configurations.Add(new AppraisalDetailMap());
            modelBuilder.Configurations.Add(new AppraisalRevMap());
            modelBuilder.Configurations.Add(new Employee_AppraisalMap());
            modelBuilder.Configurations.Add(new MyEMployeeMap());
            modelBuilder.Configurations.Add(new ReceivedRequirementMap());
            modelBuilder.Configurations.Add(new RegisteredUserMap());
            modelBuilder.Configurations.Add(new RequirementDetailMap());
            modelBuilder.Configurations.Add(new RequirementDetails_tMap());
        }
    }
}
