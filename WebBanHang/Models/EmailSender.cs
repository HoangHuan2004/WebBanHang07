using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebBanHang.Models
{
    public class EmailSender : Controller
    {
        public Task SendEmailAsync (string email, string subject, String htmlMessage)
        {
            return Task.CompletedTask;
        }
    }
}
