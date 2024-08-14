using IClinicBot.Domain.Entidades.CadastroContext;
using IClinicBot.Domain.Interfaces.IServicesCadastroContext;
using IClinicBot.Domain.ViewModel.ViewModelCadastroContext;
using IClinicBot.Infra.SqlServer.Interfaces.IRepositoryCadastroContext;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mail;
using System.Net;

namespace IClinicBot.Application.API.Services.ControllerCadastroContext
{
    public class ServiceContato : IServiceContato
    {
        public IRepositoryContato _repositoryContato;

        public ServiceContato(IRepositoryContato repository)
        {
            _repositoryContato = repository;
        }

        public List<Contato> GetAllContato()
        {
            return _repositoryContato.GetAllContato();
        }

        public Contato PostContato(ViewModelContato contato)
        {
            var insertContato = new Contato 
            { 
                Nome = contato.Nome,
                Sobrenome = contato.Sobrenome,
                Telefone = contato.Telefone,
                Email = contato.Email,
                Mensagem = contato.Mensagem
            };

            var ok = _repositoryContato.PostContato(insertContato);

            if (ok)
                EnviaEmailContato(insertContato);

            return insertContato;
        }

        private void EnviaEmailContato(Contato contato)
        {
            var mensagem = $"Olá {contato.Nome},\r\n\r\nObrigado por entrar em contato conosco! Recebemos a sua mensagem e queremos assegurar que ela está em boas mãos.\r\n\r\nNossa equipe está analisando sua solicitação e em breve retornaremos com uma resposta ou com as informações que você precisa. Se precisar de algo urgente, não hesite em nos informar.\r\n\r\nFique à vontade para responder a este e-mail caso tenha mais dúvidas ou queira compartilhar mais detalhes.\r\n\r\nAgradecemos pela sua paciência e confiança!\r\n\r\nAtenciosamente IClinicalBot";

            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                Credentials = new NetworkCredential("iclinicalbot@gmail.com", "c s p q f b d t s c w k s l k d"),
                EnableSsl = true,
                UseDefaultCredentials = false
            };

            MailMessage mail = new MailMessage
            {
                From = new MailAddress("iclinicalbot@gmail.com"),
                Subject = "IClinicalBot",
                Body = mensagem,
                IsBodyHtml = false,
            };

            mail.To.Add(contato.Email);

            try
            {
                smtpClient.Send(mail);
                Console.WriteLine("Email enviado com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao enviar email: " + ex.Message);
            }
        }
    }
}