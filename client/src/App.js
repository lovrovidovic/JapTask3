import './App.css';
import { Header } from './Components/UI/Header';
import { Router } from './Router/Router';

function App() {
  return (
    <div className="App">
      <Header title="Categories" />
      <Router />
    </div>
  );
}

export default App;
