import React from 'react';
import { Link } from 'react-router-dom';
import './App.css';

const App = () => {
  return (
    <div className="App">
      <h1>Blob Storage Viewer</h1>
      <nav>
        <ul>
          <li><Link to="/blobs">Blobs</Link></li>
          <li><Link to="/downloads">Downloads</Link></li>
          <li><Link to="/likes">Likes</Link></li>
          <li><Link to="/transactions">Transactions</Link></li>
          <li><Link to="/users">Users</Link></li>
        </ul>
      </nav>
    </div>
  );
}

export default App;
