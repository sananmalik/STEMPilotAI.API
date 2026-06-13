import { useEffect, useState } from "react";
import api from "../services/api";

function Dashboard() {
  const [stats, setStats] = useState(null);

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
    </div>
  );
}

export default Dashboard;