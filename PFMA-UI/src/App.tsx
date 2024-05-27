
import './App.css';
import { Route, Routes } from 'react-router-dom';

import Home from './Pages/home';
import Finances from './Pages/finance';
import Login from './Pages/login';
import Expenditure from './Pages/expenditures';

function App() {
  return (
    <div className="App">
      <Routes>
        <Route path="/" element={<Home />}></Route>
        <Route path="/finances" element={<Finances />}></Route>
        <Route path="/login" element={<Login />}></Route>
        <Route path="/expenditure" element={<Expenditure />}></Route>
      </Routes>
    </div>
  );
}

export default App;
