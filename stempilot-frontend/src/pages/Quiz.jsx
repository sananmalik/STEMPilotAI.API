import { useEffect, useState } from "react";
import { useParams } from "react-router-dom";
import api from "../services/api";

function Quiz() {
  const { subjectId } = useParams();

  const [questions, setQuestions] = useState([]);

  const [answers, setAnswers] = useState([]);

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

  const selectAnswer = (questionId, answer) => {
  setAnswers(prev => {
    const filtered = prev.filter(
      a => a.questionId !== questionId
    );

    return [
      ...filtered,
      {
        questionId,
        selectedAnswer: answer
      }
    ];
  });
};
  
  const submitQuiz = async () => {
  try {
    const response = await api.post("/Quiz/submit", {
      userId: 1,
      subjectId: Number(subjectId),
      answers: answers
    });

    alert(
      `Score: ${response.data.score}/${response.data.totalQuestions}`
    );
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

          <label>
  <input
    type="radio"
    name={`q${question.questionId}`}
    onChange={() => selectAnswer(question.questionId, "A")}
  />
  A. {question.optionA}
</label>

<br />

<label>
  <input
    type="radio"
    name={`q${question.questionId}`}
    onChange={() => selectAnswer(question.questionId, "B")}
  />
  B. {question.optionB}
</label>

<br />

<label>
  <input
    type="radio"
    name={`q${question.questionId}`}
    onChange={() => selectAnswer(question.questionId, "C")}
  />
  C. {question.optionC}
</label>

<br />

<label>
  <input
    type="radio"
    name={`q${question.questionId}`}
    onChange={() => selectAnswer(question.questionId, "D")}
  />
  D. {question.optionD}
</label>

          <hr />
        </div>
      ))}
      <button onClick={submitQuiz}>
  Submit Quiz
</button>
    </div>
  );
}

export default Quiz;