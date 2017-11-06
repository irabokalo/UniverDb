using AutoMapper;
using AutoMapper.QueryableExtensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University.DAL.Models;

namespace University.DAL
{
    public class UniversityRepository
    {
        private UniversityDbContext _ctx;
        private IConfigurationProvider _mapper;
        public UniversityRepository()
        {
            _ctx = new UniversityDbContext();
            _mapper = AutoMapperConfig.GetMapper();
        }

        #region Get methods
        private List<UniversityObjectViewModel> GetUniversityObjects()
        {
            return _ctx.UniversityObjects
                .Where(o => o.Sealed).ProjectTo<UniversityObjectViewModel>(_mapper).ToList();
        }

        private List<EntrantViewModel> GetEntrants()
        {
            return _ctx.Entrants
                .Where(o => o.Sealed).ProjectTo<EntrantViewModel>(_mapper).ToList();
        }

        private List<ExcellentStudentViewModel> GetExcellentStudents()
        {
            return _ctx.ExcellentStudents
                .Where(o => o.Sealed).ProjectTo<ExcellentStudentViewModel>(_mapper).ToList();
        }

        private List<GraduateViewModel> GetGraduates()
        {
            return _ctx.Graduates
                .Where(o => o.Sealed).ProjectTo<GraduateViewModel>(_mapper).ToList();
        }

        private List<HumanViewModel> GetHumans()
        {
            return _ctx.Humans
                .Where(o => o.Sealed).ProjectTo<HumanViewModel>(_mapper).ToList();
        }

        private List<LectureViewModel> GetLectures()
        {
            return _ctx.Lectures
                .Where(o => o.Sealed).ProjectTo<LectureViewModel>(_mapper).ToList();
        }

        private List<PairViewModel> GetPairs()
        {
            return _ctx.Pairs
                .Where(o => o.Sealed).ProjectTo<PairViewModel>(_mapper).ToList();
        }

        private List<PracticeViewModel> GetPractices()
        {
            return _ctx.Practices
                .Where(o => o.Sealed).ProjectTo<PracticeViewModel>(_mapper).ToList();
        }

        private List<StudentViewModel> GetStudents()
        {
            return _ctx.Students
                .Where(o => o.Sealed).ProjectTo<StudentViewModel>(_mapper).ToList();
        }

        private List<SubjectViewModel> GetSubjects()
        {
            return _ctx.Subjects
                .Where(o => o.Sealed).ProjectTo<SubjectViewModel>(_mapper).ToList();
        }

        private List<TeacherViewModel> GetTeachers()
        {
            return _ctx.Teachers
                .Where(o => o.Sealed).ProjectTo<TeacherViewModel>(_mapper).ToList();
        }


        #endregion

        #region inner create
        private int CreateUniversityObject(UniversityObjectViewModel obj, bool isSealed)
        {
            obj.CreationTime = DateTime.Now;
            obj.LastWriteTime = DateTime.Now;

            var w = _mapper.CreateMapper().Map<UniversityObject>(obj);
            w.Sealed = isSealed;
            w.MajorId = obj.MajorId;

            _ctx.UniversityObjects.Add(w);
          
            _ctx.SaveChanges();

            var sk = _ctx.UniversityObjects.ToList();
            return sk.Last().Id;
        }

        private int CreateHuman(HumanViewModel obj, bool isSealed)
        {
            int id = CreateUniversityObject(obj, false);
            var human = _mapper.CreateMapper().Map<Human>(obj);
            human.Id = id;
            human.Sealed = isSealed;          
            _ctx.Humans.Add(human);         
            _ctx.SaveChanges();
            return id;
        }

        private int CreateEntrant(EntrantViewModel entrant, bool isSealed)
        {
            int id = CreateHuman(entrant, false);
          
            _ctx.Entrants.Add(_mapper.CreateMapper().Map<Entrant>(entrant));
            _mapper.CreateMapper().Map<Entrant>(entrant).Id = id;
            _ctx.SaveChanges();
            return id;
        }

        private int CreateSubject(SubjectViewModel obj, bool isSealed)
        {
            int id = CreateUniversityObject(obj, false);
         
            _ctx.Subjects.Add(_mapper.CreateMapper().Map<Subject>(obj));
            _mapper.CreateMapper().Map<Subject>(obj).Id = id;
            _ctx.SaveChanges();
            return id;
        }

        private int CreateStudent(StudentViewModel entrant, bool isSealed)
        {
            int id = CreateHuman(entrant, false);
          
            _ctx.Students.Add(_mapper.CreateMapper().Map<Student>(entrant));
            _mapper.CreateMapper().Map<Student>(entrant).Id = id;
            _ctx.SaveChanges();
            return id;
        }

        private int CreateGraduate(GraduateViewModel obj, bool isSealed)
        {
            int id = CreateStudent(obj, false);
          
            _ctx.Graduates.Add(_mapper.CreateMapper().Map<Graduate>(obj));
            _mapper.CreateMapper().Map<Graduate>(obj).Id = id;
            _ctx.SaveChanges();
            return id;
        }

        private int CreateExcellentStudent(ExcellentStudentViewModel obj, bool isSealed)
        {
            int id = CreateStudent(obj, false);
            _mapper.CreateMapper().Map<ExcellentStudent>(obj).Id = id;
            _ctx.ExcellentStudents.Add(_mapper.CreateMapper().Map<ExcellentStudent>(obj));
           
            _ctx.SaveChanges();
            return id;
        }

        private int CreateTeacher(TeacherViewModel entrant, bool isSealed)
        {
            int id = CreateHuman(entrant, false);
            _mapper.CreateMapper().Map<Teacher>(entrant).Id = id;
            _ctx.Teachers.Add(_mapper.CreateMapper().Map<Teacher>(entrant));
            
            _ctx.SaveChanges();
            return id;
        }

        private int CreatePair(PairViewModel obj, bool isSealed)
        {
            int id = CreateUniversityObject(obj, false);
            _mapper.CreateMapper().Map<Pair>(obj).Id = id;
            _ctx.Pairs.Add(_mapper.CreateMapper().Map<Pair>(obj));
            _ctx.SaveChanges();
            return id;
        }

        private int CreateLecture(PairViewModel obj, bool isSealed)
        {
            int id = CreatePair(obj, false);
            _mapper.CreateMapper().Map<Lecture>(obj).Id = id;
            _ctx.Lectures.Add(_mapper.CreateMapper().Map<Lecture>(obj));
            _ctx.SaveChanges();
            return id;
        }

        private int CreatePractice(PracticeViewModel obj, bool isSealed)
        {
            int id = CreatePair(obj, false);
            _mapper.CreateMapper().Map<Practice>(obj).Id = id;
            _ctx.Practices.Add(_mapper.CreateMapper().Map<Practice>(obj));
            _ctx.SaveChanges();
            return id;
        }
        #endregion

        #region Create
        public int CreateUniversityObject(UniversityObjectViewModel obj)
        {
            return CreateUniversityObject(obj, true);
        }

        public int CreateSubject(SubjectViewModel obj)
        {
            return CreateSubject(obj, true);
        }

        public int CreateTeacher(TeacherViewModel obj)
        {
            return CreateTeacher(obj, true);
        }

        public int CreateEntrant(EntrantViewModel obj)
        {
            return CreateEntrant(obj, true);
        }

        public int CreateHuman(HumanViewModel obj)
        {
            return CreateHuman(obj, true);
        }

        public int CreateStudent(StudentViewModel obj)
        {
            return CreateStudent(obj, true);
        }

        public int CreateGraduate(GraduateViewModel obj)
        {
            return CreateGraduate(obj, true);
        }

        public int CreateExcellentStudent(ExcellentStudentViewModel obj)
        {
            return CreateExcellentStudent(obj, true);
        }

        public int CreatePair(PairViewModel obj)
        {
            return CreatePair(obj, true);
        }

        public int CreateLecture(LectureViewModel obj)
        {
            return CreateLecture(obj, true);
        }

        public int CreatePractice(PracticeViewModel obj)
        {
            return CreatePractice(obj, true);
        }
        #endregion

        #region Get by ID
        public UniversityObjectViewModel GetUObjectById(int id)
        {
            return GetUniversityObjects().First(o => o.Id == id);
        }

        public SubjectViewModel GetSubjectById(int id)
        {
            return GetSubjects().First(o => o.Id == id);
        }

        public StudentViewModel GetStudentById(int id)
        {
            return GetStudents().First(o => o.Id == id);
        }

        public EntrantViewModel GetEntrantById(int id)
        {
            return GetEntrants().First(o => o.Id == id);
        }

        public HumanViewModel GetHumanById(int id)
        {
            return GetHumans().First(o => o.Id == id);
        }

        public GraduateViewModel GetGraduateById(int id)
        {
            return GetGraduates().First(o => o.Id == id);
        }

        public ExcellentStudentViewModel GetExcellentStudentById(int id)
        {
            return GetExcellentStudents().First(o => o.Id == id);
        }

        public PairViewModel GetPairById(int id)
        {
            return GetPairs().First(o => o.Id == id);
        }

        public PracticeViewModel GetPracticeById(int id)
        {
            return GetPractices().First(o => o.Id == id);
        }

        public LectureViewModel GetLectureById(int id)
        {
            return GetLectures().First(o => o.Id == id);
        }
        #endregion

        #region GetUObjectsByMajor(int? major)

        public IEnumerable<UniversityObjectViewModel> GetUObjectsByMajor(int? major)
        {
            return GetUniversityObjects().Where(o => o.MajorId == major);
        }

        public IEnumerable<SubjectViewModel> GetBySubjectMajor(int? major)
        {
            return GetSubjects().Where(o => o.MajorId == major);
        }

        public IEnumerable<HumanViewModel> GetByHumanMajor(int? major)
        {
            return GetHumans().Where(o => o.MajorId == major);
        }

        public IEnumerable<StudentViewModel> GetByStudentMajor(int? major)
        {
            return GetStudents().Where(o => o.MajorId == major);
        }

        public IEnumerable<GraduateViewModel> GetByGraduateMajor(int? major)
        {
            return GetGraduates().Where(o => o.MajorId == major);
        }

        public IEnumerable<EntrantViewModel> GetByEntrantMajor(int? major)
        {
            return GetEntrants().Where(o => o.MajorId == major);
        }

        public IEnumerable<ExcellentStudentViewModel> GetByExcellentStudentMajor(int? major)
        {
            return GetExcellentStudents().Where(o => o.MajorId == major);
        }

        public IEnumerable<PairViewModel> GetByPairMajor(int? major)
        {
            return GetPairs().Where(o => o.MajorId == major);
        }

        public IEnumerable<LectureViewModel> GetByLectureMajor(int? major)
        {
            return GetLectures().Where(o => o.MajorId == major);
        }


        public IEnumerable<PracticeViewModel> GetByPracticeMajor(int? major)
        {
            return GetPractices().Where(o => o.MajorId == major);
        }

        public IEnumerable<TeacherViewModel> GetByTeacherMajor(int? major)
        {
            return GetTeachers().Where(o => o.MajorId == major);
        }


        public Dictionary<string, IEnumerable<UniversityObjectViewModel>> GetAllObjectsByMajor(int? major)
        {
            Dictionary<string, IEnumerable<UniversityObjectViewModel>> dictionary = new Dictionary<string, IEnumerable<UniversityObjectViewModel>>();
            dictionary.Add("University Object", GetUObjectsByMajor(major));
            dictionary.Add("Human", GetByHumanMajor(major));
            dictionary.Add("Student", GetByStudentMajor(major));
            dictionary.Add("Entrant", GetByEntrantMajor(major));
            dictionary.Add("Subject", GetBySubjectMajor(major));
            dictionary.Add("Graduate", GetByGraduateMajor(major));
            dictionary.Add("Excellent Student", GetByExcellentStudentMajor(major));
            dictionary.Add("Teacher", GetByTeacherMajor(major));
            dictionary.Add("Pair", GetByPairMajor(major));
            dictionary.Add("Practice", GetByPracticeMajor(major));
            dictionary.Add("Lecture", GetByLectureMajor(major));

            return dictionary;
        }

        #endregion
    }
}
