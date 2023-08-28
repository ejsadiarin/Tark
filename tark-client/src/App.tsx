import { useState } from 'react'
import { Button } from './components/ui/button'
import Navbar from './components/Navbar'
import { Sidebar } from './components/Sidebar'
import { ThemeProvider } from './components/ui/theme-provider'
import { ModeToggle } from './components/ui/mode-toggle'

function App() {
  return (
    <>
      <ThemeProvider defaultTheme="dark" storageKey="vite-ui-theme">
        <ModeToggle />
        <div className='flex h-full '>


          {/* <Navbar /> */}
          <Sidebar />

          {/* Main Dashboard UI */}
          <div className='flex w-full '>
            <h1>main</h1>
          </div>


        </div>
        {/* Footer */}
        <div className="bg-[#0f172a] text-white flex justify-center">
          <h1 className="text-xl">Made by Ej Sadiarin</h1>
        </div>
      </ThemeProvider>
    </>
  )
}

export default App
