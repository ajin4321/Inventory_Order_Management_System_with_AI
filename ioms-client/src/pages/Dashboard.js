import React, { useEffect, useState } from "react";
import api from "../services/api";
import { BarChart, Bar, XAxis, YAxis, Tooltip, ResponsiveContainer } from "recharts";

function Dashboard() {
  const [productData, setProductData] = useState([]);

  useEffect(() => {
    api.get("/products").then((res) => {
      const data = res.data.map((p) => ({
        name: p.name,
        stock: p.stockQuantity,
      }));
      setProductData(data);
    });
  }, []);

  return (
    <div className="page">
      <h2>Dashboard</h2>
      <div className="chart-container">
        <h3>Stock Levels</h3>
        <ResponsiveContainer width="100%" height={300}>
          <BarChart data={productData}>
            <XAxis dataKey="name" />
            <YAxis />
            <Tooltip />
            <Bar dataKey="stock" fill="#007bff" />
          </BarChart>
        </ResponsiveContainer>
      </div>
    </div>
  );
}

export default Dashboard;
