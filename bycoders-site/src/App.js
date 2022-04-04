import { Menu } from './components/commom';
import { Route, Routes } from "react-router-dom";
import './App.css'
import { Login, TransactionsView, Upload } from './components/features';

function App() {
  return (
    <div className="app">
      <div>
        <Menu />
      </div>
      <div className="container" >
        <Routes>
          <Route path="/" element={<Login />} />
          <Route path="transactions" element={<TransactionsView />} />
          <Route path="upload" element={<Upload />} />
        </Routes>
      </div>
    </div>
  );
}

export default App;
