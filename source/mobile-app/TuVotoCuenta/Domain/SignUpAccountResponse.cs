﻿namespace TuVotoCuenta.Domain
{
    public class SignUpAccountResponse : HttpResponseBase
    {
        public bool IsSucceded { get; set; }
        public string Image { get; set; }
		public int ResultId { get; set; }
    }
}