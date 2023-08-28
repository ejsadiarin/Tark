import { useState } from 'react'
import { Button } from './components/ui/button'
import Navbar from './components/Navbar'

function App() {
  return (
    <>
      <div className='flex flex-col h-full '>

        <Navbar />

        {/* Main Dashboard UI */}
        <div className='flex w-full '>
          <h1>main</h1>
        </div>


      </div>
      {/* Footer */}
      <div className="bg-[#0f172a] text-white flex justify-center">
        <h1 className="text-xl">Made by Ej Sadiarin</h1>
      </div>
    </>
  )
}

export default App
