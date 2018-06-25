namespace SimpleTask.Dto
{
    using Abp.Application.Services.Dto;

    public class PagedInputDto : IPagedResultRequest
    {
        public int MaxResultCount { get; set; }

        public int SkipCount { get; set; }
    }
}