import React from "react";
import { Link } from "react-router-dom";
// import "./Sidebar.css";

function Sidebar() {
  return (
    <div className="sidebar">
      <h2>IOMS</h2>
      <ul>
        <li><Link to="/">Dashboard</Link></li>
        <li><Link to="/products">Products</Link></li>
        {/* <li><Link to="/suppliers">Suppliers</Link></li>
        <li><Link to="/customers">Customers</Link></li> */}
        {/* <li><Link to="/orders">Orders</Link></li> */}
      </ul> 
    </div>
  );
}

export default Sidebar;
