import { useEffect, useState } from "react";
import { useParams } from "react-router-dom";
import api from "../services/api";

function Quiz() {
  const { subjectId } = useParams();

  const [questions, setQuestions] = useState([]);

  useEffect(() => {
    loadQuestions();
  }, []);

  const loadQuestions = async () => {
    try {
      const response = await api.get(
        `/Questions/subject/${subjectId}`
      );

      setQuestions(response.data);
    }
    catch (error) {
      console.log(error);
    }
  };

  return (
    <div>
      <h1>Quiz</h1>

      {questions.map(question => (
        <div key={question.questionId}>
          <h3>{question.questionText}</h3>

          <p>A. {question.optionA}</p>
          <p>B. {question.optionB}</p>
          <p>C. {question.optionC}</p>
          <p>D. {question.optionD}</p>

          <hr />
        </div>
      ))}
    </div>
  );
}

export default Quiz;