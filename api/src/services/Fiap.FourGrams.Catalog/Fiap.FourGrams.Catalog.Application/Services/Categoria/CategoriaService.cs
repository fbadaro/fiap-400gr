using AutoMapper;
using Fiap.FourGrams.Catalog.Domain;

namespace Fiap.FourGrams.Catalog.Application;

public class CategoriaService : ICategoriaService<CategoriaDTO>
{
    private readonly ICategoriaRepository _categoriaRepository;
    private readonly IMapper _mapper;

    public CategoriaService(ICategoriaRepository categoriaRepository, IMapper mapper)
    {
        _categoriaRepository = categoriaRepository;
        _mapper = mapper;
    }

    public async Task<CategoriaDTO> CreateAsync(CategoriaDTO entityModel) =>
        _mapper.Map<CategoriaDTO>(await _categoriaRepository.CreateAsync(_mapper.Map<Categoria>(entityModel)));

    public async Task<List<CategoriaDTO>> GetAllAsync() =>
        _mapper.Map<List<CategoriaDTO>>(await _categoriaRepository.GetAllAsync());

    public async Task<CategoriaDTO> GetByIdAsync(Guid id) =>
        _mapper.Map<CategoriaDTO>(await _categoriaRepository.GetByIdAsync(id));

    public async Task<CategoriaDTO> UpdateAsync(CategoriaDTO entityModel) =>
        _mapper.Map<CategoriaDTO>(await _categoriaRepository.UpdateAsync(_mapper.Map<Categoria>(entityModel)));

    public async Task DeleteAsync(Guid id) =>
        await _categoriaRepository.DeleteAsync(id);

    public void Dispose() => _categoriaRepository?.Dispose();
}
