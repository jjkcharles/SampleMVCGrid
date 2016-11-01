using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleMVCGrid
{
    public static class SampleDbContextExtensions
    {
        public static void Seed(IApplicationBuilder app)
        {
            var context = app.ApplicationServices.GetRequiredService<SampleDbContext>();

            if(!context.Posts.Any())
            {
                context.Database.ExecuteSqlCommand("Delete from Comments");

                context.Posts.Add(new Models.Post() { Title = "Post01" });
                context.Posts.Add(new Models.Post() { Title = "Post02" });
                context.Posts.Add(new Models.Post() { Title = "Post03" });
                context.Posts.Add(new Models.Post() { Title = "Post04" });
                context.Posts.Add(new Models.Post() { Title = "Post05" });
                context.Posts.Add(new Models.Post() { Title = "Post06" });
                context.Posts.Add(new Models.Post() { Title = "Post07" });
                context.Posts.Add(new Models.Post() { Title = "Post08" });
                context.Posts.Add(new Models.Post() { Title = "Post09" });
                context.Posts.Add(new Models.Post() { Title = "Post10" });
                context.Posts.Add(new Models.Post() { Title = "Post11" });
                context.Posts.Add(new Models.Post() { Title = "Post12" });
                context.Posts.Add(new Models.Post() { Title = "Post13" });
                context.Posts.Add(new Models.Post() { Title = "Post14" });
                context.Posts.Add(new Models.Post() { Title = "Post15" });
                context.Posts.Add(new Models.Post() { Title = "Post16" });
                context.Posts.Add(new Models.Post() { Title = "Post17" });
                context.Posts.Add(new Models.Post() { Title = "Post18" });

                context.SaveChanges();

                context.Comments.Add(new Models.Comment() { Title = "Post01 Comment01", Post = context.Posts.Where(p => p.Title == "Post01").Single() });
                context.Comments.Add(new Models.Comment() { Title = "Post01 Comment02", Post = context.Posts.Where(p => p.Title == "Post01").Single() });
                context.Comments.Add(new Models.Comment() { Title = "Post01 Comment03", Post = context.Posts.Where(p => p.Title == "Post01").Single() });

                context.Comments.Add(new Models.Comment() { Title = "Post02 Comment01", Post = context.Posts.Where(p => p.Title == "Post02").Single() });
                context.Comments.Add(new Models.Comment() { Title = "Post02 Comment02", Post = context.Posts.Where(p => p.Title == "Post02").Single() });

                context.Comments.Add(new Models.Comment() { Title = "Post03 Comment01", Post = context.Posts.Where(p => p.Title == "Post03").Single() });
                context.Comments.Add(new Models.Comment() { Title = "Post04 Comment01", Post = context.Posts.Where(p => p.Title == "Post04").Single() });
                context.Comments.Add(new Models.Comment() { Title = "Post05 Comment01", Post = context.Posts.Where(p => p.Title == "Post05").Single() });
                context.Comments.Add(new Models.Comment() { Title = "Post06 Comment01", Post = context.Posts.Where(p => p.Title == "Post06").Single() });
                context.Comments.Add(new Models.Comment() { Title = "Post07 Comment01", Post = context.Posts.Where(p => p.Title == "Post07").Single() });
                context.Comments.Add(new Models.Comment() { Title = "Post08 Comment01", Post = context.Posts.Where(p => p.Title == "Post08").Single() });
                context.Comments.Add(new Models.Comment() { Title = "Post09 Comment01", Post = context.Posts.Where(p => p.Title == "Post09").Single() });

                context.Comments.Add(new Models.Comment() { Title = "Post10 Comment01", Post = context.Posts.Where(p => p.Title == "Post10").Single() });
                context.Comments.Add(new Models.Comment() { Title = "Post10 Comment02", Post = context.Posts.Where(p => p.Title == "Post10").Single() });
                context.Comments.Add(new Models.Comment() { Title = "Post10 Comment03", Post = context.Posts.Where(p => p.Title == "Post10").Single() });
                context.SaveChanges();
            }
        }
    }
}
