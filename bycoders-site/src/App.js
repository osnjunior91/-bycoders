import { Menu } from './components/commom';
import { Upload } from './components/features';
import './App.css'

function App() {
  return (
    <div className="app">
      <div>
        <Menu />
      </div>
      <div className="container" >
        <Upload />
      </div>
    </div>
  );
}

export default App;
