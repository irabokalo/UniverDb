
using AutoMapper;
using University.DAL.Models;
using University.DAL.ViewModels;

namespace University.DAL
{
    public static class AutoMapperConfig
    {
        public static IConfigurationProvider GetMapper()
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<EntrantViewModel, Entrant>();
                cfg.CreateMap<Entrant, EntrantViewModel>();

                cfg.CreateMap<ExcellentStudent, ExcellentStudentViewModel>();
                cfg.CreateMap<ExcellentStudentViewModel, ExcellentStudent>();

                cfg.CreateMap<GraduateViewModel, Graduate>();
                cfg.CreateMap<Graduate, GraduateViewModel>();

                cfg.CreateMap<HumanViewModel, Human>();
                cfg.CreateMap<Human, HumanViewModel>();

                cfg.CreateMap<LectureViewModel, Lecture>();
                cfg.CreateMap<Lecture, LectureViewModel>();

                cfg.CreateMap<PairViewModel, Pair>();
                cfg.CreateMap<Pair, PairViewModel>();

                cfg.CreateMap<PracticeViewModel, Practice>();
                cfg.CreateMap<Practice, PracticeViewModel>();

                cfg.CreateMap<StudentViewModel, Student>();
                cfg.CreateMap<Student, StudentViewModel>();

                cfg.CreateMap<SubjectViewModel, Subject>();
                cfg.CreateMap<Subject, SubjectViewModel>();

                cfg.CreateMap<WorkerViewModel, Worker>();
                cfg.CreateMap<Worker, WorkerViewModel>();

                cfg.CreateMap<RoomViewModel, Room>();
                cfg.CreateMap<Room, RoomViewModel>();

                cfg.CreateMap<UniversityObject, UniversityObjectViewModel>();
                cfg.CreateMap<UniversityObjectViewModel, UniversityObject>();

            });

            return config;
        }
    }
}
