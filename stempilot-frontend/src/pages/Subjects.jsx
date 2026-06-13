import { useEffect, useState } from "react";
import { useNavigate } from "react-router-dom";
import api from "../services/api";

function Subjects() {
  const [subjects, setSubjects] = useState([]);

  const navigate = useNavigate();

  useEffect(() => {
    loadSubjects();
  }, []);

  const loadSubjects = async () => {
    try {
      const response = await api.get("/Subjects");
      setSubjects(response.data);
    } catch (error) {
      console.log(error);
    }
  };

  return (
    <div>
      <h1>Subjects</h1>

      {subjects.map(subject => (
        <div key={subject.subjectId}>
          <h3>{subject.subjectName}</h3>

          <button
            onClick={() => navigate(`/quiz/${subject.subjectId}`)}
          >
            Start Quiz
          </button>

          <hr />
        </div>
      ))}
    </div>
  );
}

export default Subjects;