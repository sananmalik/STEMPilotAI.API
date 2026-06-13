import { useEffect, useState } from "react";
import api from "../services/api";
import { useNavigate } from "react-router-dom";

function Dashboard() {
  const [stats, setStats] = useState(null);

  const navigate = useNavigate();

  useEffect(() => {
    loadDashboard();
  }, []);

  const loadDashboard = async () => {
    try {
      const response = await api.get("/Dashboard/user/1");

      setStats(response.data);
    }
    catch (error) {
      console.log(error);
    }
  };

  if (!stats)
  {
    return <h2>Loading...</h2>;
  }

  return (
    <div>
      <h1>STEMPilot AI Dashboard</h1>

      <p>Total Attempts: {stats.totalAttempts}</p>

      <p>Average Score: {stats.averageScore}</p>

      <p>Best Score: {stats.bestScore}</p>

      <p>Worst Score: {stats.worstScore}</p>

      <button onClick={() => navigate("/subjects")}>
      Take Quiz
      </button>
    </div>
  );
}

export default Dashboard;