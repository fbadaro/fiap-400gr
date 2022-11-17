using AutoMapper;
using Fiap.FourGrams.Catalog.Domain;

namespace Fiap.FourGrams.Catalog.Application;

public class ProdutoService : IProdutoService<ProdutoDTO>
{
    private readonly IProdutoRepository _produtoRepository;
    private readonly IMapper _mapper;

    public ProdutoService(IProdutoRepository produtoRepository, IMapper mapper)
    {
        _produtoRepository = produtoRepository;
        _mapper = mapper;
    }

    public async Task<ProdutoDTO> CreateAsync(ProdutoDTO entityModel) =>
        _mapper.Map<ProdutoDTO>(await _produtoRepository.CreateAsync(_mapper.Map<Produto>(entityModel)));

    public async Task<List<ProdutoDTO>> GetAllAsync() =>
        _mapper.Map<List<ProdutoDTO>>(await _produtoRepository.GetAllAsync());

    public async Task<ProdutoDTO> GetByIdAsync(Guid id) =>
        _mapper.Map<ProdutoDTO>(await _produtoRepository.GetByIdAsync(id));

    public async Task<ProdutoDTO> UpdateAsync(ProdutoDTO entityModel) =>
        _mapper.Map<ProdutoDTO>(await _produtoRepository.UpdateAsync(_mapper.Map<Produto>(entityModel)));

    public async Task DeleteAsync(Guid id) =>
        await _produtoRepository.DeleteAsync(id);

    public void Dispose() => _produtoRepository?.Dispose();
}
