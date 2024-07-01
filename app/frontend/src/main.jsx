import React from 'react';
import ReactDOM from 'react-dom/client';
import { BrowserRouter as Router, Route, Routes } from 'react-router-dom';
import App from './App.jsx';
import BlobList from './BlobList.jsx';
import DownloadList from './DownloadList.jsx';
import LikeList from './LikeList.jsx';
import TransactionList from './TransactionList.jsx';
import UserList from './UserList.jsx';
import './index.css';

const Main = () => {
  return (
    <Router>
      <Routes>
        <Route path="/" element={<App />} />
        <Route path="/blobs" element={<BlobList />} />
        <Route path="/downloads" element={<DownloadList />} />
        <Route path="/likes" element={<LikeList />} />
        <Route path="/transactions" element={<TransactionList />} />
        <Route path="/users" element={<UserList />} />
      </Routes>
    </Router>
  );
};

ReactDOM.createRoot(document.getElementById('root')).render(
  <React.StrictMode>
    <Main />
  </React.StrictMode>,
);
