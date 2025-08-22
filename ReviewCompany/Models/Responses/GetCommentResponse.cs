namespace ReviewCompany.Models.Responses
{
    public class CommentDto
    {
        public Guid ParentComentId { get; set; }
        public string UserName { get; set; } = string.Empty;
        public string UserImageUrl { get; set; } = string.Empty;
        public int UserId { get; set; }
        public string Content { get; set; } = string.Empty;  // nvarchar -> string
        public int NumberLike { get; set; }
        public int NumberDislike { get; set; }
        public int NumberAngry { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Type { get; set; } = string.Empty;     // nvarchar -> string
    }

    public class GetCommentResponse : BaseResponse<List<CommentDto>> { }
}
