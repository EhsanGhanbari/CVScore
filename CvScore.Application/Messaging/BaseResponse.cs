﻿namespace CvScore.Application.Messaging
{
    public abstract class BaseResponse
    {
        public bool Success { get; set; }
        public string Message { get; set; }
    }
}
