﻿using System;



namespace API.DTOs
{
    public class PhotoDto
    {
        public int Id { get; set; }

        public string url { get; set; }

        public bool isMain { get; set; }
    }
}