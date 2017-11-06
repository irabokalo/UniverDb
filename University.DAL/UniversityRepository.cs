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
            var entrantmodel = _mapper.CreateMapper().Map<Entrant>(entrant);
            entrantmodel.Id = id;
            _ctx.Entrants.Add(entrantmodel);
            _ctx.SaveChanges();
            return id;
        }

        private int CreateSubject(SubjectViewModel obj, bool isSealed)
        {
            int id = CreateUniversityObject(obj, false);
            var sub = _mapper.CreateMapper().Map<Subject>(obj);
            sub.Id = id;
            _ctx.Subjects.Add(sub);
            _mapper.CreateMapper().Map<Subject>(obj).Id = id;
            _ctx.SaveChanges();
            return id;
        }

        private int CreateStudent(StudentViewModel entrant, bool isSealed)
        {
            int id = CreateHuman(entrant, false);
            var student = _mapper.CreateMapper().Map<Student>(entrant);
            student.Id = id;
            _ctx.Students.Add(student);
            _mapper.CreateMapper().Map<Student>(entrant).Id = id;
            _ctx.SaveChanges();
            return id;
        }

        private int CreateGraduate(GraduateViewModel obj, bool isSealed)
        {
            int id = CreateStudent(obj, false);
            var grad = _mapper.CreateMapper().Map<Graduate>(obj);
            grad.Id = id;
            _ctx.Graduates.Add(grad);
            _ctx.SaveChanges();
            return id;
        }

        private int CreateExcellentStudent(ExcellentStudentViewModel obj, bool isSealed)
        {
            int id = CreateStudent(obj, false);
            var exc = _mapper.CreateMapper().Map<ExcellentStudent>(obj);
            exc.Id = id;
            _ctx.ExcellentStudents.Add(exc);

            _ctx.SaveChanges();
            return id;
        }

        private int CreateTeacher(TeacherViewModel entrant, bool isSealed)
        {
            int id = CreateHuman(entrant, false);
            var teacher = _mapper.CreateMapper().Map<Teacher>(entrant);
            teacher.Id = id;
            _ctx.Teachers.Add(teacher);

            _ctx.SaveChanges();
            return id;
        }

        private int CreatePair(PairViewModel obj, bool isSealed)
        {
            int id = CreateUniversityObject(obj, false);
            var pair = _mapper.CreateMapper().Map<Pair>(obj);
            pair.Id = id;
            _ctx.Pairs.Add(pair);
            _ctx.SaveChanges();
            return id;
        }

        private int CreateLecture(PairViewModel obj, bool isSealed)
        {
            int id = CreatePair(obj, false);
            var lecture = _mapper.CreateMapper().Map<Lecture>(obj);
            lecture.Id = id;
            _ctx.Lectures.Add(lecture);
            _ctx.SaveChanges();
            return id;
        }

        private int CreatePractice(PracticeViewModel obj, bool isSealed)
        {
            int id = CreatePair(obj, false);
            var practice = _mapper.CreateMapper().Map<Practice>(obj);
            practice.Id = id;
            _ctx.Practices.Add(practice);
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

        #region update
        public void UpdateUObject(UniversityObjectViewModel uObj)
        {
            UniversityObject dbUObj = _ctx.UniversityObjects.First(o => o.Id == uObj.Id);
            dbUObj.TypeName = uObj.TypeName;
            dbUObj.LastWriteTime = DateTime.Now;

            _ctx.SaveChanges();
        }

        public void UpdatePerson(HumanViewModel human)
        {
            Human dbPerson = _ctx.Humans.First(p => p.Id == human.Id);

            dbPerson.Name = human.Name;
            dbPerson.Surname = human.Surname;
            dbPerson.Age = human.Age;

            UpdateUObject(human);
        }

        public void UpdateStudent(StudentViewModel student)
        {
            Student dbStudent = _ctx.Students.First(s => s.Id == student.Id);

            dbStudent.FavoriteSubject = student.FavoriteSubject;
            dbStudent.MediumMark = student.MediumMark;

            UpdatePerson(student);
        }

        public void UpdateEntrant(EntrantViewModel entrant)
        {
            Entrant dbEntrant = _ctx.Entrants.First(e => e.Id == entrant.Id);

            dbEntrant.DesiredFaculty = entrant.DesiredFaculty;
            dbEntrant.School = entrant.School;

            UpdatePerson(entrant);
        }

        public void UpdateTeacher(TeacherViewModel teacher)
        {
            Teacher dbEntrant = _ctx.Teachers.First(e => e.Id == teacher.Id);

            dbEntrant.Education = teacher.Education;

            UpdatePerson(teacher);
        }

        public void UpdateSubject(SubjectViewModel subject)
        {
            Subject dbPerson = _ctx.Subjects.First(p => p.Id == subject.Id);

            dbPerson.Description = subject.Description;
            dbPerson.Name = subject.Name;

            UpdateUObject(subject);
        }

        public void UpdateGraduate(GraduateViewModel graduate)
        {
            Graduate dbStudent = _ctx.Graduates.First(s => s.Id == graduate.Id);

            dbStudent.YearOfGraduation = graduate.YearOfGraduation;


            UpdateStudent(graduate);
        }

        public void UpdateExcellentStudent(ExcellentStudentViewModel graduate)
        {
            ExcellentStudent dbStudent = _ctx.ExcellentStudents.First(s => s.Id == graduate.Id);

            dbStudent.ScholarShip = graduate.ScholarShip;


            UpdateStudent(graduate);
        }

        public void UpdatePair(PairViewModel subject)
        {
            Pair dbPerson = _ctx.Pairs.First(p => p.Id == subject.Id);

            dbPerson.DurationInMinutes = subject.DurationInMinutes;
            dbPerson.RoomNumber = subject.RoomNumber;

            UpdateUObject(subject);
        }

        public void UpdatePractice(PracticeViewModel subject)
        {
            Practice dbPerson = _ctx.Practices.First(p => p.Id == subject.Id);

            dbPerson.PracticeTask = subject.PracticeTask;
            dbPerson.HomeWork = subject.HomeWork;

            UpdatePair(subject);
        }

        public void UpdateLecture(LectureViewModel subject)
        {
            Lecture dbPerson = _ctx.Lectures.First(p => p.Id == subject.Id);

            dbPerson.TheoryInformation = subject.TheoryInformation;


            UpdatePair(subject);
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
