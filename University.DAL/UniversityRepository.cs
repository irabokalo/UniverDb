using AutoMapper;
using AutoMapper.QueryableExtensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University.DAL.Models;
using University.DAL.ViewModels;

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

        private List<RoomViewModel> GetRooms()
        {
            return _ctx.Rooms
                .Where(o => o.Sealed).ProjectTo<RoomViewModel>(_mapper).ToList();
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

        private List<WorkerViewModel> GetWorkers()
        {
            return _ctx.Workers
                .Where(o => o.Sealed).ProjectTo<WorkerViewModel>(_mapper).ToList();
        }


        #endregion
        #region inner create
        private int CreateUniversityObject(UniversityObjectViewModel uobj, bool isSealed)
        {
            uobj.CreationTime = DateTime.Now;
            uobj.LastWriteTime = DateTime.Now;

            UniversityObject dbUObj = new UniversityObject
            {
                CreationTime = uobj.CreationTime,
                LastWriteTime = uobj.LastWriteTime,
                MajorId = uobj.MajorId,
                TypeName = uobj.TypeName,
                Sealed = isSealed
            };

            _ctx.UniversityObjects.Add(dbUObj);
            _ctx.SaveChanges();

            uobj.Id = dbUObj.Id;
            return dbUObj.Id;
        }

        private int CreateHuman(HumanViewModel obj, bool isSealed)
        {
            int id = CreateUniversityObject(obj, false);
            obj.Id = id;
            var human = _mapper.CreateMapper().Map<Human>(obj);

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

        private int CreateRoom(RoomViewModel obj, bool isSealed)
        {
            int id = CreateUniversityObject(obj, false);
            var sub = _mapper.CreateMapper().Map<Room>(obj);
            sub.Id = id;
            _ctx.Rooms.Add(sub);
            _mapper.CreateMapper().Map<Room>(obj).Id = id;
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

        private int CreateWorker(WorkerViewModel entrant, bool isSealed)
        {
            int id = CreateHuman(entrant, false);
            var Worker = _mapper.CreateMapper().Map<Worker>(entrant);
            Worker.Id = id;
            _ctx.Workers.Add(Worker);

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
        #region Delete
        public void DeleteUObject(int id)
        {
            UniversityObject forRemove = _ctx.UniversityObjects.First(o => o.Id == id);

            _ctx.UniversityObjects.Remove(forRemove);

            _ctx.SaveChanges();
        }

        public void DeletePerson(int id)
        {
            Human forRemove = _ctx.Humans.First(p => p.Id == id);

            _ctx.Humans.Remove(forRemove);

            DeleteUObject(id);
        }

        public void DeleteSubject(int id)
        {
            Subject forRemove = _ctx.Subjects.First(p => p.Id == id);

            _ctx.Subjects.Remove(forRemove);

            DeleteUObject(id);
        }

        public void DeleteRoom(int id)
        {
            Room forRemove = _ctx.Rooms.First(p => p.Id == id);

            _ctx.Rooms.Remove(forRemove);

            DeleteUObject(id);
        }

        public void DeleteStudent(int id)
        {
            Student forRemove = _ctx.Students.First(p => p.Id == id);

            _ctx.Students.Remove(forRemove);

            DeletePerson(id);
        }


        public void DeleteEntrant(int id)
        {
            Entrant forRemove = _ctx.Entrants.First(p => p.Id == id);

            _ctx.Entrants.Remove(forRemove);

            DeletePerson(id);
        }


        public void DeleteWorker(int id)
        {
            Worker forRemove = _ctx.Workers.First(p => p.Id == id);

            _ctx.Workers.Remove(forRemove);

            DeletePerson(id);
        }

        public void DeletePair(int id)
        {
            Pair forRemove = _ctx.Pairs.First(p => p.Id == id);

            _ctx.Pairs.Remove(forRemove);

            DeleteUObject(id);
        }

        public void DeleteGraduate(int id)
        {
            Graduate forRemove = _ctx.Graduates.First(p => p.Id == id);

            _ctx.Graduates.Remove(forRemove);

            DeleteStudent(id);
        }

        public void DeleteExcellentStudent(int id)
        {
            ExcellentStudent forRemove = _ctx.ExcellentStudents.First(p => p.Id == id);

            _ctx.ExcellentStudents.Remove(forRemove);

            DeleteStudent(id);
        }

        public void DeletePractice(int id)
        {
            Practice forRemove = _ctx.Practices.First(p => p.Id == id);

            _ctx.Practices.Remove(forRemove);

            DeletePair(id);
        }

        public void DeleteLecture(int id)
        {
            Lecture forRemove = _ctx.Lectures.First(p => p.Id == id);

            _ctx.Lectures.Remove(forRemove);

            DeletePair(id);
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

        public int CreateRoom(RoomViewModel obj)
        {
            return CreateRoom(obj, true);
        }

        public int CreateWorker(WorkerViewModel obj)
        {
            return CreateWorker(obj, true);
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

        public void UpdateWorker(WorkerViewModel Worker)
        {
            Worker dbEntrant = _ctx.Workers.First(e => e.Id == Worker.Id);

            dbEntrant.Education = Worker.Education;

            UpdatePerson(Worker);
        }

        public void UpdateSubject(SubjectViewModel subject)
        {
            Subject dbPerson = _ctx.Subjects.First(p => p.Id == subject.Id);

            dbPerson.Description = subject.Description;
            dbPerson.Name = subject.Name;

            UpdateUObject(subject);
        }

        public void UpdateRoom(RoomViewModel subject)
        {
            Room dbPerson = _ctx.Rooms.First(p => p.Id == subject.Id);

            dbPerson.Number = subject.Number;

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
            return _mapper.CreateMapper().Map<UniversityObjectViewModel>(_ctx.UniversityObjects.First(o => o.Id == id));
        }

        public SubjectViewModel GetSubjectById(int id)
        {
            return _mapper.CreateMapper().Map<SubjectViewModel>(_ctx.Subjects.First(o => o.Id == id));
        }

        public RoomViewModel GetRoomById(int id)
        {
            return _mapper.CreateMapper().Map<RoomViewModel>(_ctx.Subjects.First(o => o.Id == id));
        }

        public WorkerViewModel GetWorkerById(int id)
        {
            return _mapper.CreateMapper().Map<WorkerViewModel>(_ctx.Workers.First(o => o.Id == id));
        }
        public StudentViewModel GetStudentById(int id)
        {
            return _mapper.CreateMapper().Map<StudentViewModel>(_ctx.Students.First(o => o.Id == id));
        }

        public EntrantViewModel GetEntrantById(int id)
        {
            return _mapper.CreateMapper().Map<EntrantViewModel>(_ctx.Entrants.First(o => o.Id == id));
        }

        public HumanViewModel GetHumanById(int id)
        {
            return _mapper.CreateMapper().Map<HumanViewModel>(_ctx.Humans.First(o => o.Id == id));
        }

        public GraduateViewModel GetGraduateById(int id)
        {
            return _mapper.CreateMapper().Map<GraduateViewModel>(_ctx.Graduates.First(o => o.Id == id));
        }

        public ExcellentStudentViewModel GetExcellentStudentById(int id)
        {
            return _mapper.CreateMapper().Map<ExcellentStudentViewModel>(_ctx.ExcellentStudents.First(o => o.Id == id));
        }

        public PairViewModel GetPairById(int id)
        {
            return _mapper.CreateMapper().Map<PairViewModel>(_ctx.Pairs.First(o => o.Id == id));
        }

        public PracticeViewModel GetPracticeById(int id)
        {
            return _mapper.CreateMapper().Map<PracticeViewModel>(_ctx.Practices.First(o => o.Id == id));
        }

        public LectureViewModel GetLectureById(int id)
        {
            return _mapper.CreateMapper().Map<LectureViewModel>(_ctx.Lectures.First(o => o.Id == id));
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

        public IEnumerable<RoomViewModel> GetByRoomMajor(int? major)
        {
            return GetRooms().Where(o => o.MajorId == major);
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

        public IEnumerable<WorkerViewModel> GetByWorkerMajor(int? major)
        {
            return GetWorkers().Where(o => o.MajorId == major);
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
            dictionary.Add("Worker", GetByWorkerMajor(major));
            dictionary.Add("Pair", GetByPairMajor(major));
            dictionary.Add("Practice", GetByPracticeMajor(major));
            dictionary.Add("Lecture", GetByLectureMajor(major));

            return dictionary;
        }

        #endregion
    }
}
