import { Menu } from './components/commom';
import Login from './components/features';
import './App.css'

function App() {
  return (
    <div className="App">
      <div>
        <Menu />
      </div>
      <div>
        <Login />
      </div>
    </div>
  );
}

export default App;
