import './App.css';
import { Categories } from './Components/Categories/Categories';
import { Header } from './Components/UI/Header';

function App() {
  return (
    <div className="App">
      <Header title="Categories" />
      <Categories />
    </div>
  );
}

export default App;
