namespace StaffHub.DAL.Entities;

public abstract class BaseEntity
{
        public int Id { get; set; }

        public DateTime CreatedOn { get; set; }
        public string? CreatedBy { get; set; } = null!;

        public DateTime? ModifiedOn { get; set; }
        public string? ModifiedBy { get; set; }

        public bool IsDeleted { get; set; } = false;    
        public DateTime? DeletedOn { get; set; }
        public string? DeletedBy { get; set; }


 
}
