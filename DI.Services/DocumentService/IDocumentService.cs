using DI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DI.Services.DocumentService
{
    public interface IDocumentService
    {
        Task<List<Document>> GetAllDocumentsAsync();
        Task<Document> GetDocumentByIdAsync(int Id);
        Task<bool> AddDocumentAsync(Document document);
        Task<bool> UpdateDocumentAsync(int Id, Document document);
        Task<bool> RemoveDocumentAsync(int Id);
    }
}
