using AutoMapper;
using SGBL.Core.Application.ViewModels.Author;
using SGBL.Core.Application.ViewModels.Genero;
using SGBL.Core.Application.ViewModels.Libro;
using SGBL.Core.Domain.Entities;

namespace SGBL.Core.Application.Mappings
{
    public class GeneralProfile : Profile
    {
        public GeneralProfile()
        {
            #region LibroProfile
            CreateMap<Libro, LibroViewModel>()
                .ForMember(x => x.AuthorName, opt => opt.Ignore())
                .ForMember(x => x.GeneroName, opt => opt.Ignore())
                .ReverseMap()
                .ForMember(x => x.Created, opt => opt.Ignore())
                .ForMember(x => x.CreatedBy, opt => opt.Ignore())
                .ForMember(x => x.LastModified, opt => opt.Ignore())
                .ForMember(x => x.LastModifiedBy, opt => opt.Ignore());

            CreateMap<Libro, SaveLibroViewModel>()
                .ForMember(x => x.Author, opt => opt.Ignore())
                .ForMember(x => x.Genero, opt => opt.Ignore())
                .ReverseMap()
                .ForMember(x => x.Created, opt => opt.Ignore())
                .ForMember(x => x.CreatedBy, opt => opt.Ignore())
                .ForMember(x => x.LastModified, opt => opt.Ignore())
                .ForMember(x => x.LastModifiedBy, opt => opt.Ignore())
                .ForMember(x => x.Author, opt => opt.Ignore())
                .ForMember(x => x.Genero, opt => opt.Ignore());
            #endregion

            #region AutorProfile
            CreateMap<Author, AuthorViewModel>()
                .ForMember(x => x.LibrosQuantity, opt => opt.Ignore())
                .ReverseMap()
                .ForMember(x => x.Created, opt => opt.Ignore())
                .ForMember(x => x.CreatedBy, opt => opt.Ignore())
                .ForMember(x => x.LastModified, opt => opt.Ignore())
                .ForMember(x => x.LastModifiedBy, opt => opt.Ignore());

            CreateMap<Author, SaveAutorViewModel>()
                .ReverseMap()
                .ForMember(x => x.Created, opt => opt.Ignore())
                .ForMember(x => x.CreatedBy, opt => opt.Ignore())
                .ForMember(x => x.LastModified, opt => opt.Ignore())
                .ForMember(x => x.LastModifiedBy, opt => opt.Ignore())
                .ForMember(x => x.Libro, opt => opt.Ignore());
            #endregion

            #region GeneroProfile
            CreateMap<Genero, GeneroViewModel>()
                .ForMember(x => x.LibrosQuantity, opt => opt.Ignore())
                .ReverseMap()
                .ForMember(x => x.Created, opt => opt.Ignore())
                .ForMember(x => x.CreatedBy, opt => opt.Ignore())
                .ForMember(x => x.LastModified, opt => opt.Ignore())
                .ForMember(x => x.LastModifiedBy, opt => opt.Ignore());

            CreateMap<Genero, SaveGeneroViewModel>()
                .ReverseMap()
                .ForMember(x => x.Created, opt => opt.Ignore())
                .ForMember(x => x.CreatedBy, opt => opt.Ignore())
                .ForMember(x => x.LastModified, opt => opt.Ignore())
                .ForMember(x => x.LastModifiedBy, opt => opt.Ignore())
                .ForMember(x => x.Libro, opt => opt.Ignore());
            #endregion
        }
    }
}
