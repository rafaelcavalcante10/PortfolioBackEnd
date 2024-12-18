using AutoMapper;
using Portfolio.Domain.Models;
using Portfolio.Repositories.Contracts;
using Portfolio.Services.Contracts;
using Portfolio.Services.ViewModels;
using System;
using System.IO;
using System.Threading.Tasks;

namespace Portfolio.Services
{
    public class BaseService<ViewModel> : IBaseService<ViewModel> where ViewModel : class
    {
        protected readonly IGraduationRepository _graduationRepository;
        protected readonly IDeveloperRepository _developerRepository;
        protected readonly IExperienceRepository _experienceRepository;
        protected readonly IExperienceDetailRepository _experienceDetailRepository;
        protected readonly IMapper _mapper;
        public BaseService(IDeveloperRepository developerRepository, IGraduationRepository graduationRepository, IExperienceRepository experienceRepository, IExperienceDetailRepository experienceDetailRepository, IMapper mapper)
        {
            _developerRepository = developerRepository;
            _graduationRepository = graduationRepository;
            _experienceRepository = experienceRepository;
            _experienceDetailRepository = experienceDetailRepository;
            _mapper = mapper;
        }

        public virtual Task<ViewModel> BuscaPorId(int id)
        {
            throw new NotImplementedException();
        }

        public virtual Task<ViewModel[]> BuscarTodos()
        {
            throw new NotImplementedException();
        }

        public virtual void LerBaseTxt()
        {
            var sr = new StreamReader("basedados.txt");

            var line = sr.ReadLine();
            while (line != null)
            {
                var arrayLine = line.Split(';');
                switch (arrayLine[0].ToString())
                {
                    case "Developer":
                        if (_developerRepository.GetById(Convert.ToInt32(arrayLine[1])) != null) break;
                        var viewModel = new PortfolioVM();
                        viewModel.id = Convert.ToInt32(arrayLine[1]);
                        viewModel.nome = arrayLine[2];
                        viewModel.nascimento = DateTime.ParseExact(arrayLine[3], "dd/MM/yyyy", null);
                        viewModel.endereco = arrayLine[4];
                        viewModel.bairro = arrayLine[5];
                        viewModel.cidade = arrayLine[6];
                        viewModel.email = arrayLine[7];
                        viewModel.site = arrayLine[8];
                        viewModel.telefone = arrayLine[9];
                        viewModel.sobre = arrayLine[10];
                        viewModel.resumo = arrayLine[11];
                        viewModel.informacao = arrayLine[12];
                        viewModel.cargo = arrayLine[13];
                        viewModel.cargocompleto = arrayLine[14];

                        _developerRepository.Insert(_mapper.Map<Developer>(viewModel));
                        break;
                    case "Graduation":
                        if (_graduationRepository.GetById(Convert.ToInt32(arrayLine[1])) != null) break;
                        var graduationVM = new GraduationVM();
                        graduationVM.id = Convert.ToInt32(arrayLine[1]);
                        graduationVM.curso = arrayLine[2];
                        graduationVM.inicio = arrayLine[3];
                        graduationVM.fim = arrayLine[4];
                        graduationVM.universidade = arrayLine[5];
                        graduationVM.descricao = arrayLine[6];
                        graduationVM.id_developer= Convert.ToInt32(arrayLine[7]);

                        _graduationRepository.Insert(_mapper.Map<Graduation>(graduationVM));
                        break;
                    case "Experience":
                        if (_experienceRepository.GetById(Convert.ToInt32(arrayLine[1])) != null) break;
                        var experienceVM = new ExperienceVM();
                        experienceVM.id = Convert.ToInt32(arrayLine[1]);
                        experienceVM.cargo = arrayLine[2];
                        experienceVM.inicio = arrayLine[3];
                        experienceVM.fim = arrayLine[4];
                        experienceVM.empresa = arrayLine[5];
                        experienceVM.id_developer = Convert.ToInt32(arrayLine[6]);

                        _experienceRepository.Insert(_mapper.Map<Experience>(experienceVM));
                        break;
                    case "ExperienceDetail":
                        if (_experienceDetailRepository.GetById(Convert.ToInt32(arrayLine[1]), Convert.ToInt32(arrayLine[2])) != null) break;
                        var experienceDetailVM = new ExperienceDetailVM();
                        experienceDetailVM.id = Convert.ToInt32(arrayLine[1]);
                        experienceDetailVM.id_experience = Convert.ToInt32(arrayLine[2]);
                        experienceDetailVM.detalhe = arrayLine[3];
                        _experienceDetailRepository.Insert(_mapper.Map<ExperienceDetail>(experienceDetailVM));
                        break;
                }
                line = sr.ReadLine();
            }
            sr.Close();
        }
    }
}
