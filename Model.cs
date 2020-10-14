﻿using System;

namespace Model
{
    public class Page
    {
    }
   public class Activity
    {
        public int activityId { get; set; }
        public string activityName{ get; set; }
        public DateTime endTime { get; set; }
    }
    public class WorkInfo
    {
        public int workId { get; set; }
        public string workName { get; set; }
        public DateTime endTime { get; set; }
        
    }
    public class Comment
    {
        public int CommentId { get; set; }
        public string CommentName { get; set; }
        public DateTime endTime { get; set; }
    }
    public class WorkFindPage : Page
    {
        public string workName { get; set; }
    }
    public class WorkMyPage : Page
    {
        public string userName { get; set; }
    }
    public class CommentPage : Page
    {
        public string userName { get; set; }
    }
    public class ActivityNo : Activity
    {
        public int num { get; set; }
    }
    public class ActivityName
    {
        public int activityId { get; set; }
        public string activityName { get; set; }
    }
    public class WorkInfoNo : WorkInfo
    {
        public int num { get; set; }
        public string activityName { get; set; }
    }
    public class CommentNo : Comment
    {
        public int num { get; set; }
        public string activityName { get; set; }
    }
}
