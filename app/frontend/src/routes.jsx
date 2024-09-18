import React from 'react';
import { BrowserRouter as Router, Routes, Route } from 'react-router-dom';
import App from './App.jsx';
import Joao from './pages/Joao.jsx';
import Raissa from './pages/Raissa.jsx';
import Gabriel from './pages/Gabriel.jsx';
import Mirella from './pages/Mirella.jsx';

const AppRoutes = () => {
    return (
        <Router>
            <Routes>
                <Route path="/" element={<App />} />
                <Route path="/joao" element={<Joao />} />
                <Route path="/raissa" element={<Raissa />} />
                <Route path="/gabriel" element={<Gabriel />} />
                <Route path="/mirella" element={<Mirella />} />
            </Routes>
        </Router>
    );
}

export default AppRoutes;
