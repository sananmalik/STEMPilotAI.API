import { BrowserRouter, Routes, Route } from "react-router-dom";

import Login from "./pages/Login";
import Dashboard from "./pages/Dashboard";
import Subjects from "./pages/Subjects";
import Quiz from "./pages/Quiz";

function App() {
  return (
    <BrowserRouter>
      <Routes>
        <Route path="/" element={<Login />} />
        <Route path="/dashboard" element={<Dashboard />} />
        <Route path="/subjects" element={<Subjects />} />
        <Route path="/quiz/:subjectId" element={<Quiz />} />
      </Routes>
    </BrowserRouter>
  );
}

export default App;