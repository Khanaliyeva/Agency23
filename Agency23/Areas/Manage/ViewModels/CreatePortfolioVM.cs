﻿namespace Agency23.Areas.Manage.ViewModels
{
    public class CreatePortfolioVM
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public IFormFile File { get; set; }
        public string? ImgUrl { get; set; }
    }
}
