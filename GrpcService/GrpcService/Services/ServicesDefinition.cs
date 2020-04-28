using Grpc.Core;
using GrpcService.Model;
using GrpcService.Protos;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GrpcService.Services
{
    public class ServicesClass : Service.ServiceBase
    {
        private readonly ILogger<ServicesClass> _logger;
        private readonly DatabaseContext _context;
       
        public ServicesClass(ILogger<ServicesClass> logger, DatabaseContext context)
        {
            _logger = logger;
            _context = context;
        }

        public override Task<AddCommentResponse> AddComment(Protos.AddCommentRequest request, ServerCallContext context)
        {

            AddCommentResponse output = new AddCommentResponse();

            Comment comment = new Comment();
            comment.PostPostId = request.Postid;
            comment.Text = request.Text;
            comment.Post = _context.Posts.Find(request.Postid);
            output.BResult = false;
            if (comment == null || request.Postid == 0)
            {
                return Task.FromResult(output);
            }
            if (comment.CommentId == 0)
            {
                _context.Comments.Add(comment);
                _context.SaveChanges();
                output.BResult = true;
            }

            return Task.FromResult(output);
        
        }


        public override Task<UpdateCommentResponse> UpdateComment(UpdateCommentRequest request, ServerCallContext context)
        {
            UpdateCommentResponse output = new UpdateCommentResponse();

            Comment oldComment = _context.Comments.Find(request.Id);
            if (request.Text != null)
            {
                oldComment.Text = request.Text;
            }
            if ((oldComment.PostPostId != request.Postid) && (request.Postid != 0))
            {
                oldComment.PostPostId = request.Postid;
            }
            _context.SaveChanges();
            output.Id = oldComment.CommentId;

            return Task.FromResult(output);
        }


        public override Task<GetCommentByIdResponse> GetCommentById(GetCommentByIdRequest request, ServerCallContext context)
        {
            GetCommentByIdResponse output = new GetCommentByIdResponse();

            Comment comment = _context.Comments.Find(request.Id);
            if(comment != null)
            {
                output.Id = request.Id;
                output.Postid = comment.PostPostId;
                output.Text = comment.Text;
            }
            else
            {
                output.Id = request.Id;
                output.Postid = 0;
                output.Text = null;
            }

            return Task.FromResult(output);
        }



        public override Task<AddPostResponse> AddPost(Protos.AddPostRequest request, ServerCallContext context)
        {

            AddPostResponse output = new AddPostResponse();

            Post post = new Post();
            post.Date = System.DateTime.Parse(request.Date);
            post.Description = request.Date;
            post.Domain = request.Domain;
            output.BResult = false;
            if (post == null)
            {
                return Task.FromResult(output);
            }
            if (post.PostId == 0)
            {
                _context.Posts.Add(post);
                _context.SaveChanges();
                output.BResult = true;
            }

            return Task.FromResult(output);

        }


        public override Task<UpdatePostResponse> UpdatePost(UpdatePostRequest request, ServerCallContext context)
        {
            UpdatePostResponse output = new UpdatePostResponse();

            Post oldPost = _context.Posts.Find(request.Id);
            if (request.Domain != null)
            {
                oldPost.Domain = request.Domain;
            }
            if (request.Date != null)
            {
                oldPost.Date = System.DateTime.Parse(request.Date);
            }
            if (request.Description != null)
            {
                oldPost.Description = request.Description;
            }

            _context.SaveChanges();
            output.Id = oldPost.PostId;

            return Task.FromResult(output);
        }



        public override Task<GetPostByIdResponse> GetPostById(GetPostByIdRequest request, ServerCallContext context)
        {
            GetPostByIdResponse output = new GetPostByIdResponse();

            Post post= _context.Posts.Find(request.Id);
            if (post != null)
            {
                output.Id = request.Id;
                output.Description = post.Description;
                output.Domain  = post.Domain;
                output.Date = post.Date.ToString();
            }
            else
            {
                output.Id = request.Id;
                output.Description = null;
                output.Domain = null;
                output.Date = null;
            }

            return Task.FromResult(output);
        }


        public override Task<DeletePostResponse> DeletePost(DeletePostRequest request, ServerCallContext context)
        {
            DeletePostResponse output = new DeletePostResponse();

            _context.Remove(request.Id);
            _context.SaveChanges();
            return Task.FromResult(output);
        }
    }
}
