import { Menu } from './components/commom';
import { TransactionsView } from './components/features';
import './App.css'

function App() {
  return (
    <div className="app">
      <div>
        <Menu />
      </div>
      <div className="container" >
        <TransactionsView />
      </div>
    </div>
  );
}

export default App;
