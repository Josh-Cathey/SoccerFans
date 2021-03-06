﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FootyFans.Models;

namespace FootyFans.Repositories
{
	public class FakeRepository : IRepository
	{
		private static List<Video> videos = new List<Video>();
		private static List<ForumPost> forumPosts = new List<ForumPost>();
		public List<Video> Videos { get { return videos; } }
		public List<ForumPost> ForumPosts { get { return forumPosts; } }

		static FakeRepository()
		{
			AddTestData();
		}

		public Video GetVideoByDescription(string description)
		{
			Video video = videos.Find(v => v.Description == description);
			return video;
		}

		public void AddComment(Video video, Comment comment)
		{
			if (video != null & comment != null)
			{
				video.Comments.Add(comment);
			}
		}

		public void AddForumPost(ForumPost newPost)
		{
			if (newPost != null)
			{
				ForumPosts.Add(newPost);
			}
		}

		public ForumPost GetForumPostBySubject(string subject)
		{
			ForumPost post = ForumPosts.Find(p => p.Subject == subject);
			return post;
		}

		static void AddTestData()
		{
			Video skills2019 = new Video()
			{
				VideoUrl = "../videos/Skills2019.mp4",
				Description = "Amazing skill moves from 2019"
			};
			Comment skillsComment = new Comment()
			{
				CommentText = "Love these skills!"
			};
			skills2019.Comments.Add(skillsComment);
			videos.Add(skills2019);

			Video ronaldinhoSkills = new Video()
			{
				VideoUrl = "../videos/RonaldinhoSkills.mp4",
				Description = "Ronaldinho's legendary skills"
			};
			Comment ronaldinhoComment = new Comment() { CommentText = "I wish Ronaldinho was still playing." };
			ronaldinhoSkills.Comments.Add(ronaldinhoComment);
			videos.Add(ronaldinhoSkills);

			Video messiSkills = new Video()
			{
				VideoUrl = "../videos/MessiSkills.mp4",
				Description = "Leo Messi's career highlights"
			};
			Comment messiComment = new Comment() { CommentText = "He's the greatest player every!" };
			messiSkills.Comments.Add(messiComment);
			videos.Add(messiSkills);

			Video ronaldoSkills = new Video()
			{
				VideoUrl = "../videos/RonaldoSkills.mp4",
				Description = "Cristiano Ronaldo Manchester United highlights"
			};
			Comment ronaldoComment = new Comment() { CommentText = "Ronaldo has always been one of the greatest players ever." };
			ronaldoSkills.Comments.Add(ronaldoComment);
			videos.Add(ronaldoSkills);
		}
	}
}
