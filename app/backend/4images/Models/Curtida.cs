﻿using Microsoft.Identity.Client;

namespace _4images.Models
{
    public class Curtida
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public int ImageId { get; set; }

        public DateTime timeItWasLiked { get; set; }
    }
}
