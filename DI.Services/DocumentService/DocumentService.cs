using DI.Domain.Entities;
using DI.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DI.Services.DocumentService
{
    public class DocumentService : IDocumentService
    {
        private readonly IGRepository<Document> _repository;

        public DocumentService(IGRepository<Document> repository)
        {
            _repository = repository;
        }

        public async Task<bool> AddDocumentAsync(Document document)
        {
            return await _repository.AddedAsync(document);
        }

        public async Task<List<Document>> GetAllDocumentsAsync()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<Document> GetDocumentByIdAsync(int Id)
        {
            return await _repository.GetByIdAsync(Id);
        }

        public async Task<bool> RemoveDocumentAsync(int Id)
        {
            return await _repository.RemoveAsync(Id);
        }

        public async Task<bool> UpdateDocumentAsync(int Id, Document document)
        {
            return await _repository.UpdateAsync(Id, document);
        }
    }
}
